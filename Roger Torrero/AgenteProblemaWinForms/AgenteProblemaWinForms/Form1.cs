using Microsoft.Agents.AI;

namespace AgenteProblemaWinForms;

public sealed class Form1 : Form
{
    private readonly ComboBox cmbProveedor = new();
    private readonly TextBox txtProblema = new();
    private readonly TextBox txtInstrucciones = new();
    private readonly TextBox txtConsulta = new();
    private readonly Button btnCrearAgente = new();
    private readonly Button btnEnviar = new();
    private readonly Button btnNuevaSesion = new();
    private readonly RichTextBox rtbConversacion = new();
    private readonly Label lblEstado = new();

    private AIAgent? agente;
    private AgentSession? sesion;
    private bool enviando;

    public Form1()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        Text = "PlanificaUTP | Agente de estudio";
        StartPosition = FormStartPosition.CenterScreen;
        MinimumSize = new Size(850, 650);
        Size = new Size(1120, 850);
        Font = new Font("Segoe UI", 9F);

        var panelPrincipal = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 5,
            Padding = new Padding(12)
        };
        panelPrincipal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        panelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
        panelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 245));
        panelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        panelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 150));
        Controls.Add(panelPrincipal);

        var encabezado = new Label
        {
            AutoSize = true,
            Text = "PlanificaUTP — organiza tus horas de estudio",
            Font = new Font("Segoe UI", 17F, FontStyle.Bold),
            ForeColor = Color.FromArgb(36, 92, 61),
            Padding = new Padding(0, 0, 0, 8)
        };
        panelPrincipal.Controls.Add(encabezado, 0, 0);

        var panelAcciones = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = false,
            Padding = new Padding(0, 6, 0, 0)
        };
        panelPrincipal.Controls.Add(panelAcciones, 0, 1);

        var lblProveedor = new Label
        {
            AutoSize = true,
            Text = "Proveedor:",
            Margin = new Padding(0, 8, 6, 0)
        };
        cmbProveedor.Name = "cmbProveedor";
        cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbProveedor.Width = 145;
        cmbProveedor.Items.AddRange(new object[] { "OpenAI", "Claude", "Gemini", "Grok" });
        cmbProveedor.SelectedIndex = 0;

        btnCrearAgente.Name = "btnCrearAgente";
        btnCrearAgente.Text = "Crear agente";
        btnCrearAgente.AutoSize = true;
        btnCrearAgente.Click += async (_, _) => await CrearAgenteAsync();

        btnNuevaSesion.Name = "btnNuevaSesion";
        btnNuevaSesion.Text = "Nueva sesión";
        btnNuevaSesion.AutoSize = true;
        btnNuevaSesion.Click += async (_, _) => await NuevaSesionAsync();

        panelAcciones.Controls.Add(lblProveedor);
        panelAcciones.Controls.Add(cmbProveedor);
        panelAcciones.Controls.Add(btnCrearAgente);
        panelAcciones.Controls.Add(btnNuevaSesion);

        var panelConfiguracion = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 1,
            Padding = new Padding(0, 4, 0, 8)
        };
        panelConfiguracion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42));
        panelConfiguracion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58));
        panelPrincipal.Controls.Add(panelConfiguracion, 0, 2);

        txtProblema.Name = "txtProblema";
        txtProblema.Multiline = true;
        txtProblema.ScrollBars = ScrollBars.Vertical;
        txtProblema.Dock = DockStyle.Fill;
        txtProblema.Text = "A algunos estudiantes les cuesta distribuir sus horas de estudio entre varios temas y recordar cuánto tiempo tienen disponible.";
        panelConfiguracion.Controls.Add(CrearGrupo("Problema delimitado", txtProblema), 0, 0);

        txtInstrucciones.Name = "txtInstrucciones";
        txtInstrucciones.Multiline = true;
        txtInstrucciones.ScrollBars = ScrollBars.Vertical;
        txtInstrucciones.Dock = DockStyle.Fill;
        txtInstrucciones.Text = InstruccionesIniciales;
        panelConfiguracion.Controls.Add(CrearGrupo("Instrucciones del agente", txtInstrucciones), 1, 0);

        txtConsulta.Name = "txtConsulta";
        txtConsulta.Multiline = true;
        txtConsulta.ScrollBars = ScrollBars.Vertical;
        txtConsulta.Dock = DockStyle.Fill;
        txtConsulta.PlaceholderText = "Ejemplo: Tengo 3 horas y 4 temas para repasar. Ayúdame a repartirlos.";
        txtConsulta.KeyDown += TxtConsulta_KeyDown;

        rtbConversacion.Name = "rtbConversacion";
        rtbConversacion.Multiline = true;
        rtbConversacion.ReadOnly = true;
        rtbConversacion.Dock = DockStyle.Fill;
        rtbConversacion.BackColor = Color.White;
        rtbConversacion.Font = new Font("Segoe UI", 9.5F);

        var cajaConversacion = CrearGrupo("Conversación y evidencia", rtbConversacion);
        panelPrincipal.Controls.Add(cajaConversacion, 0, 3);

        var panelConsulta = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 3,
            Padding = new Padding(0, 7, 0, 0)
        };
        panelConsulta.RowStyles.Add(new RowStyle(SizeType.Absolute, 22));
        panelConsulta.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        panelConsulta.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
        panelPrincipal.Controls.Add(panelConsulta, 0, 4);

        panelConsulta.Controls.Add(new Label
        {
            AutoSize = true,
            Text = "Tu consulta (Ctrl+Enter para enviar):"
        }, 0, 0);
        panelConsulta.Controls.Add(txtConsulta, 0, 1);

        var panelEnviar = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = false,
            Padding = new Padding(0, 4, 0, 0)
        };
        panelConsulta.Controls.Add(panelEnviar, 0, 2);

        btnEnviar.Name = "btnEnviar";
        btnEnviar.Text = "Enviar consulta";
        btnEnviar.AutoSize = true;
        btnEnviar.Click += async (_, _) => await EnviarConsultaAsync();

        lblEstado.Name = "lblEstado";
        lblEstado.AutoSize = true;
        lblEstado.Text = "Estado: configura la clave API y crea el agente.";
        lblEstado.Margin = new Padding(12, 8, 0, 0);
        lblEstado.ForeColor = Color.FromArgb(75, 75, 75);

        panelEnviar.Controls.Add(btnEnviar);
        panelEnviar.Controls.Add(lblEstado);

        Escribir("Sistema", "Elige OpenAI, revisa el problema y las instrucciones, y pulsa «Crear agente». Las consultas se envían al proveedor de IA; no escribas datos confidenciales.");
    }

    private static GroupBox CrearGrupo(string titulo, Control contenido)
    {
        var grupo = new GroupBox
        {
            Text = titulo,
            Dock = DockStyle.Fill,
            Padding = new Padding(8)
        };
        grupo.Controls.Add(contenido);
        return grupo;
    }

    private async Task CrearAgenteAsync()
    {
        if (enviando)
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(txtProblema.Text) || string.IsNullOrWhiteSpace(txtInstrucciones.Text))
        {
            lblEstado.Text = "Estado: completa el problema y las instrucciones.";
            return;
        }

        try
        {
            lblEstado.Text = "Estado: configurando el agente...";
            btnCrearAgente.Enabled = false;

            agente = AgentFactory.Crear(
                cmbProveedor.SelectedItem?.ToString() ?? "",
                txtProblema.Text,
                txtInstrucciones.Text);

            sesion = await agente.CreateSessionAsync();
            rtbConversacion.Clear();
            Escribir("Sistema", "Agente PlanificaUTP creado. Esta sesión conservará el contexto hasta que pulses «Nueva sesión».");
            lblEstado.Text = "Estado: agente listo con OpenAI y herramienta local.";
        }
        catch (Exception ex)
        {
            agente = null;
            sesion = null;
            lblEstado.Text = "Estado: no se pudo crear el agente.";
            Escribir("Error", ex.Message);
        }
        finally
        {
            btnCrearAgente.Enabled = true;
        }
    }

    private async Task EnviarConsultaAsync()
    {
        if (agente is null || sesion is null)
        {
            lblEstado.Text = "Estado: primero pulsa «Crear agente».";
            return;
        }

        string consulta = txtConsulta.Text.Trim();
        if (consulta.Length == 0)
        {
            lblEstado.Text = "Estado: escribe una consulta.";
            return;
        }

        try
        {
            enviando = true;
            btnEnviar.Enabled = false;
            btnCrearAgente.Enabled = false;
            btnNuevaSesion.Enabled = false;
            lblEstado.Text = "Estado: esperando la respuesta del modelo...";
            Escribir("Tú", consulta);
            txtConsulta.Clear();
            HerramientaEstudio.LimpiarEvidencia();

            AgentResponse respuesta = await agente.RunAsync(consulta, sesion);
            Escribir("PlanificaUTP", respuesta.Text ?? "El agente no devolvió texto.");

            if (HerramientaEstudio.UltimaEjecucion is { } evidencia)
            {
                Escribir("Evidencia de herramienta local", evidencia);
                lblEstado.Text = "Estado: respuesta recibida; la herramienta local se ejecutó.";
            }
            else
            {
                lblEstado.Text = "Estado: respuesta recibida; la herramienta no era necesaria en esta consulta.";
            }
        }
        catch (Exception ex)
        {
            lblEstado.Text = "Estado: ocurrió un error al consultar el proveedor.";
            Escribir("Error", ex.Message);
        }
        finally
        {
            enviando = false;
            btnEnviar.Enabled = true;
            btnCrearAgente.Enabled = true;
            btnNuevaSesion.Enabled = true;
            txtConsulta.Focus();
        }
    }

    private async Task NuevaSesionAsync()
    {
        if (enviando)
        {
            return;
        }

        if (agente is null)
        {
            rtbConversacion.Clear();
            Escribir("Sistema", "Conversación borrada. Crea el agente para iniciar una sesión nueva.");
            return;
        }

        try
        {
            sesion = await agente.CreateSessionAsync();
            rtbConversacion.Clear();
            Escribir("Sistema", "Nueva sesión iniciada. El agente ya no tiene el contexto de la conversación anterior.");
            lblEstado.Text = "Estado: sesión nueva lista.";
        }
        catch (Exception ex)
        {
            lblEstado.Text = "Estado: no se pudo iniciar una sesión nueva.";
            Escribir("Error", ex.Message);
        }
    }

    private async void TxtConsulta_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            await EnviarConsultaAsync();
        }
    }

    private void Escribir(string autor, string texto)
    {
        rtbConversacion.AppendText($"{autor}:\r\n{texto}\r\n\r\n");
        rtbConversacion.SelectionStart = rtbConversacion.TextLength;
        rtbConversacion.ScrollToCaret();
    }

    private const string InstruccionesIniciales = """
        Eres PlanificaUTP, un agente de apoyo para organizar el estudio universitario. Responde en español claro y sencillo.

        OBJETIVO
        Ayuda a convertir las horas disponibles, los temas y la fecha de evaluación en un plan breve y realista.

        REGLAS
        1. Si faltan datos necesarios (horas disponibles, cantidad o nombres de temas, fecha límite o prioridades), pregunta lo que falta antes de inventarlo.
        2. Cuando el estudiante indique las horas y la cantidad de temas o materias, utiliza la herramienta local CalcularBloques para estimar la distribución. No presentes sus resultados como una obligación ni como una garantía de nota.
        3. La herramienta reserva aproximadamente 80% del tiempo para enfoque y 20% para descansos; informa que es una estimación modificable.
        4. Prioriza los temas difíciles, próximos o que el estudiante señale como importantes. Propón pausas y un repaso final breve.
        5. Si el estudiante cambia un dato en la conversación, usa el dato nuevo y conserva el contexto de esta sesión.
        6. No afirmes conocer el horario, las asignaturas ni el calendario de la universidad si el estudiante no los proporciona.
        7. No pidas contraseñas ni información personal innecesaria. No abras enlaces ni realices acciones fuera de la aplicación.

        FORMATO DE RESPUESTA
        - Resumen de los datos recibidos.
        - Plan sugerido con duración por tema y descansos.
        - Un primer paso concreto para empezar.
        - Si falta información, termina con una pregunta breve.
        """;
}
