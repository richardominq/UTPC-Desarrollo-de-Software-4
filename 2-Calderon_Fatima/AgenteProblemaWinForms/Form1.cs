using System.Diagnostics;
using System.Text;
using Microsoft.Agents.AI;

namespace AgenteProblemaWinForms
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private AIAgent? agente;
        private AgentSession? sesion;
        private readonly StudyTools herramientas = new();
        private UsageMeter consumo = new();
        private CancellationTokenSource? solicitud;
        private bool ocupado;
        private bool cerrando;
        private int evidenciaNumero;

        public Form1()
        {
            InitializeComponent();
            cmbProveedor.SelectedIndex = 3;
            herramientas.EvidenceProduced += MostrarEvidencia;
            dgvTareas.Rows.Add("Matemáticas", 3);
            dgvTareas.Rows.Add("Programación C#", 5);
            dgvTareas.Rows.Add("Inglés", 2);
            ActualizarBotones();
            ActualizarConsumo();
            FormClosing += (_, _) => { cerrando = true; solicitud?.Cancel(); };
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string proveedor = cmbProveedor.Text;
            txtModelo.Text = AgentFactory.DefaultModel(proveedor);
            nudTarifaEntrada.Value = proveedor == "OpenAI" ? 0.15m : 0;
            nudTarifaSalida.Value = proveedor == "OpenAI" ? 0.60m : 0;
            lblClave.Text = "Clave: variable " + AgentFactory.VariableFor(proveedor);
            ActualizarConsumo();
        }

        // Doble clic en Crear agente abre este evento en Visual Studio.
        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (ocupado) return;
            try
            {
                LeerTareas();
                agente = AgentFactory.Crear(cmbProveedor.Text, txtModelo.Text.Trim(), txtNombre.Text.Trim(),
                    txtProblema.Text.Trim(), txtInstrucciones.Text.Trim(), herramientas);
                sesion = await agente.CreateSessionAsync();
                if (cerrando) return;
                lblSesion.Text = "SESIÓN ACTIVA";
                lblEstado.Text = "Agente listo. Tus mensajes conservarán el contexto de esta sesión.";
                AgregarMensaje("SISTEMA", $"{txtNombre.Text} está listo con {cmbProveedor.Text} / {txtModelo.Text}.\n" +
                    "Herramientas disponibles: ObtenerTareas y PlanificarEstudio.");
                txtConsulta.Focus();
            }
            catch (Exception ex)
            {
                agente = null;
                sesion = null;
                MessageBox.Show(this, LimpiarSecretos(ex.Message), "No se pudo crear el agente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ActualizarBotones();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ocupado || agente is null || sesion is null) return;
            string consulta = txtConsulta.Text.Trim();
            if (consulta.Length == 0) return;
            if (consulta.Length > 6000)
            {
                MessageBox.Show(this, "Escribe una consulta de hasta 6 000 caracteres.");
                return;
            }
            try { LeerTareas(); }
            catch (ArgumentException ex) { MessageBox.Show(this, ex.Message); return; }

            ocupado = true;
            solicitud = new CancellationTokenSource(TimeSpan.FromSeconds(90));
            ActualizarBotones();
            AgregarMensaje("TÚ", consulta);
            txtConsulta.Clear();
            lblEstado.Text = "El agente está trabajando…";
            var reloj = Stopwatch.StartNew();
            try
            {
                // La MISMA sesión se reutiliza en todos los turnos: memoria del agente.
                AgentResponse respuesta = await agente.RunAsync(consulta, sesion, cancellationToken: solicitud.Token);
                if (cerrando) return;
                consumo.Add(respuesta.Usage);
                AgregarMensaje(txtNombre.Text.ToUpperInvariant(), respuesta.Text);
                lblEstado.Text = $"Respuesta recibida en {reloj.Elapsed.TotalSeconds:0.0} s. Revisa la evidencia y los límites.";
                ActualizarConsumo();
            }
            catch (OperationCanceledException)
            {
                if (!cerrando) FalloConsulta("Consulta cancelada o tiempo de espera agotado (90 s).");
            }
            catch (Exception ex)
            {
                if (!cerrando) FalloConsulta(LimpiarSecretos(ex.Message));
            }
            finally
            {
                solicitud?.Dispose();
                solicitud = null;
                ocupado = false;
                if (!cerrando) ActualizarBotones();
            }
        }

        private void FalloConsulta(string mensaje)
        {
            // Evita continuar una memoria que pudo quedar parcialmente actualizada.
            agente = null;
            sesion = null;
            lblSesion.Text = "SESIÓN INTERRUMPIDA";
            lblEstado.Text = "Consulta incompleta. Inicia una nueva sesión antes de volver a consultar.";
            AgregarMensaje("SISTEMA", mensaje + "\nNo se registró una respuesta completa; el proveedor podría haber procesado parte de la solicitud.");
            btnCrear.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e) => solicitud?.Cancel();

        private void btnNuevaSesion_Click(object sender, EventArgs e)
        {
            if (ocupado) return;
            agente = null;
            sesion = null;
            consumo = new UsageMeter();
            evidenciaNumero = 0;
            rtbConversacion.Clear();
            txtEvidencia.Clear();
            lblHerramienta.Text = "Sin ejecuciones locales todavía";
            txtConsulta.Clear();
            lblSesion.Text = "SIN SESIÓN";
            lblEstado.Text = "Nueva sesión preparada. Ajusta la configuración y pulsa Crear agente.";
            ActualizarBotones();
            ActualizarConsumo();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareas.Rows.Count >= 10) { MessageBox.Show(this, "Puedes registrar hasta 10 tareas."); return; }
            int indice = dgvTareas.Rows.Add("Nueva tarea", 1);
            dgvTareas.CurrentCell = dgvTareas.Rows[indice].Cells[0];
            dgvTareas.BeginEdit(true);
        }

        private void btnQuitarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareas.CurrentRow is not null) dgvTareas.Rows.Remove(dgvTareas.CurrentRow);
        }

        private void btnProbarHerramienta_Click(object sender, EventArgs e)
        {
            try
            {
                LeerTareas();
                herramientas.PlanificarEstudio((int)nudMinutos.Value);
                lblEstado.Text = "Cálculo local realizado. Funciona sin API y no consume tokens.";
            }
            catch (ArgumentException ex) { MessageBox.Show(this, ex.Message, "Revisa las tareas"); }
        }

        private void LeerTareas()
        {
            dgvTareas.EndEdit();
            var tareas = new List<StudyTask>();
            foreach (DataGridViewRow fila in dgvTareas.Rows)
            {
                string materia = Convert.ToString(fila.Cells[0].Value)?.Trim() ?? "";
                if (!int.TryParse(Convert.ToString(fila.Cells[1].Value), out int prioridad))
                    throw new ArgumentException("La prioridad debe ser un número entero de 1 a 5.");
                tareas.Add(new StudyTask(materia, prioridad));
            }
            herramientas.SetTasks(tareas);
        }

        private void MostrarEvidencia(string evidencia)
        {
            if (cerrando || IsDisposed) return;
            if (InvokeRequired)
            {
                try { BeginInvoke(new Action(() => MostrarEvidencia(evidencia))); }
                catch (InvalidOperationException) { }
                return;
            }
            evidenciaNumero++;
            int inicio = txtEvidencia.TextLength;
            txtEvidencia.AppendText($"EVIDENCIA {evidenciaNumero} · {DateTime.Now:HH:mm:ss}\r\n{evidencia}\r\n\r\n");
            txtEvidencia.SelectionStart = inicio;
            txtEvidencia.ScrollToCaret();
            lblHerramienta.Text = evidenciaNumero == 1 ? "1 ejecución local registrada" : $"{evidenciaNumero} ejecuciones locales registradas";
        }

        private void AgregarMensaje(string autor, string texto)
        {
            rtbConversacion.SelectionStart = rtbConversacion.TextLength;
            rtbConversacion.SelectionColor = autor == "TÚ" ? Color.FromArgb(31, 115, 109) : Color.FromArgb(61, 66, 141);
            rtbConversacion.SelectionFont = new Font(rtbConversacion.Font, FontStyle.Bold);
            rtbConversacion.AppendText($"{autor} · {DateTime.Now:HH:mm}\r\n");
            rtbConversacion.SelectionColor = Color.FromArgb(41, 50, 68);
            rtbConversacion.SelectionFont = rtbConversacion.Font;
            rtbConversacion.AppendText(texto + "\r\n\r\n");
            rtbConversacion.ScrollToCaret();
            btnGuardar.Enabled = true;
        }

        private void ActualizarBotones()
        {
            bool configuracionLibre = !ocupado && agente is null;
            foreach (Control control in new Control[] { cmbProveedor, txtModelo, txtNombre, txtProblema, txtInstrucciones })
                control.Enabled = configuracionLibre;
            btnCrear.Enabled = configuracionLibre && lblSesion.Text != "SESIÓN INTERRUMPIDA";
            btnEnviar.Enabled = !ocupado && agente is not null;
            btnCancelar.Enabled = ocupado;
            btnNuevaSesion.Enabled = !ocupado;
            txtConsulta.Enabled = !ocupado;
            dgvTareas.Enabled = !ocupado;
            btnAgregarTarea.Enabled = btnQuitarTarea.Enabled = btnProbarHerramienta.Enabled = !ocupado;
            nudMinutos.Enabled = !ocupado;
            nudTarifaEntrada.Enabled = nudTarifaSalida.Enabled = !ocupado;
            btnGuardar.Enabled = !ocupado && rtbConversacion.TextLength > 0;
        }

        private void tarifas_ValueChanged(object sender, EventArgs e) => ActualizarConsumo();

        private void ActualizarConsumo()
        {
            lblTokens.Text = $"Tokens reportados: {consumo.InputTokens:N0} entrada / {consumo.OutputTokens:N0} salida";
            if (nudTarifaEntrada.Value == 0 && nudTarifaSalida.Value == 0)
                lblCosto.Text = "Costo: ingresa las tarifas de tu modelo";
            else
                lblCosto.Text = $"Estimación: USD {consumo.Estimate(nudTarifaEntrada.Value, nudTarifaSalida.Value):0.000000}";
            if (consumo.RunsWithoutUsage > 0) lblCosto.Text += " · parcial: faltan datos de uso";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using var dialogo = new SaveFileDialog { Filter = "Informe de texto (*.txt)|*.txt", DefaultExt = "txt", FileName = "sesion-agente.txt" };
            if (dialogo.ShowDialog(this) != DialogResult.OK) return;
            string informe = $"AGENTE: {txtNombre.Text}\nPROVEEDOR: {cmbProveedor.Text}\nMODELO: {txtModelo.Text}\nPROBLEMA: {txtProblema.Text}\n" +
                $"\nCONVERSACIÓN\n{rtbConversacion.Text}\nEVIDENCIA LOCAL\n{txtEvidencia.Text}\n" +
                $"\nCONSUMO\n{lblTokens.Text}\n{lblCosto.Text}\n" +
                $"Tarifas USD / millón: entrada={nudTarifaEntrada.Value}, salida={nudTarifaSalida.Value}\n";
            try
            {
                File.WriteAllText(dialogo.FileName, LimpiarSecretos(informe), Encoding.UTF8);
                lblEstado.Text = "Informe guardado con conversación, evidencia y consumo.";
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            { MessageBox.Show(this, "No se pudo guardar el informe. " + ex.Message); }
        }

        private static string LimpiarSecretos(string texto)
        {
            foreach (string proveedor in new[] { "OpenAI", "Claude", "Gemini", "Grok" })
            {
                string variable = AgentFactory.VariableFor(proveedor);
                foreach (string? clave in new[] { Environment.GetEnvironmentVariable(variable), Environment.GetEnvironmentVariable(variable, EnvironmentVariableTarget.User) })
                    if (!string.IsNullOrWhiteSpace(clave)) texto = texto.Replace(clave, "[CLAVE OCULTA]", StringComparison.Ordinal);
            }
            return texto;
        }
    }
}
