# PlanificaUTP — Laboratorio de Microsoft Agent Framework

Aplicación de escritorio Windows Forms que conversa con un agente de estudio basado en OpenAI. El agente conserva el contexto de la conversación durante una sesión y puede pedir a una función C# local que calcule una distribución orientativa de tiempo.

## Problema y alcance

Algunos estudiantes tienen dificultad para repartir el tiempo disponible entre varios temas. PlanificaUTP propone bloques de enfoque, descansos y un orden inicial para estudiar. La decisión final sobre prioridades y duración la conserva el estudiante.

Este primer prototipo implementa OpenAI. La lista muestra OpenAI, Claude, Gemini y Grok, como pide el diseño del laboratorio, pero los otros tres proveedores aún no están conectados.

## Requisitos

- Windows 10 u 11.
- Visual Studio con la carga **Desarrollo de escritorio con .NET**.
- .NET 10 SDK.
- Clave de OpenAI API con acceso al modelo `gpt-4o-mini`. El uso de la API se factura según tokens de entrada y salida; la suscripción de ChatGPT no incluye necesariamente saldo de API.

## Abrir y ejecutar

1. Descomprime el proyecto y abre `AgenteProblemaWinForms.csproj` con Visual Studio.
2. Restaura los paquetes NuGet y confirma que el proyecto usa `net10.0-windows`.
3. En Windows PowerShell, configura la clave para tu usuario. Reemplaza el texto entre comillas por la clave propia; no pegues la clave en el código ni en una captura.

   ```powershell
   [Environment]::SetEnvironmentVariable('OPENAI_API_KEY', 'TU_CLAVE_API', 'User')
   ```

4. Cierra y vuelve a abrir Visual Studio para que lea la variable de entorno.
5. Ejecuta el proyecto, deja **OpenAI** seleccionado, revisa el problema y las instrucciones, y pulsa **Crear agente**.
6. Escribe una consulta y pulsa **Enviar consulta**. Usa **Nueva sesión** para borrar el contexto temporal.

También se puede restaurar y ejecutar desde una terminal de Windows:

```powershell
dotnet restore .\AgenteProblemaWinForms.csproj
dotnet run --project .\AgenteProblemaWinForms.csproj
```

## Controles de la interfaz

| Control | Nombre | Función |
|---|---|---|
| ComboBox | `cmbProveedor` | Presenta OpenAI, Claude, Gemini y Grok. El prototipo conecta OpenAI. |
| TextBox multilínea | `txtProblema` | Define el problema que atiende el agente. |
| TextBox multilínea | `txtInstrucciones` | Permite revisar y modificar el rol, reglas y formato de respuesta. |
| TextBox multilínea | `txtConsulta` | Recibe el mensaje del estudiante; Ctrl+Enter también envía. |
| Button | `btnCrearAgente` | Construye el agente y crea una sesión. |
| Button | `btnEnviar` | Envía la consulta y muestra la respuesta. |
| Button | `btnNuevaSesion` | Crea una conversación nueva y borra el diálogo visible. |
| RichTextBox | `rtbConversacion` | Muestra el diálogo y la evidencia de uso de la herramienta local. |
| Label | `lblEstado` | Indica conexión, espera, ejecución de herramienta y errores. |

## Agente, sesión y herramienta local

- `AgentFactory.cs` construye un `AIAgent` a partir de OpenAI, el problema escrito en pantalla y las instrucciones elegidas.
- `CreateSessionAsync()` crea el contexto temporal. Cada llamada a `RunAsync(consulta, sesion)` reutiliza ese contexto hasta pulsar **Nueva sesión**.
- `HerramientaEstudio.CalcularBloques` valida de 0.5 a 12 horas y de 1 a 12 temas. Calcula 80% de enfoque, 20% de descansos, minutos promedio por tema y número estimado de bloques de hasta 50 minutos.
- La función solo calcula y devuelve texto. No accede al sistema de archivos, no abre direcciones web ni envía mensajes.
- Después de cada respuesta, la interfaz muestra los datos de entrada y el resultado cuando el agente llamó a la función; esto sirve como evidencia visible.

## Instrucciones verificables del agente

El prompt inicial establece que PlanificaUTP debe:

1. Preguntar por datos faltantes y no inventar horas, temas ni fechas.
2. Usar la herramienta local cuando hay horas disponibles y número de temas.
3. Indicar que el cálculo es una estimación y que el estudiante puede ajustarlo.
4. Priorizar los temas difíciles o cercanos según lo que indique la persona.
5. Responder con resumen, plan, descansos, siguiente paso y pregunta si faltan datos.
6. No solicitar contraseñas ni realizar acciones externas.

## Pruebas manuales

| Prueba | Consulta/acción | Resultado que se debe observar |
|---|---|---|
| Configuración | Pulsar «Crear agente» con clave válida y OpenAI elegido. | Estado «agente listo» y conversación iniciada. |
| Herramienta | «Tengo 3 horas y 4 temas para repasar. Calcula una distribución con descansos». | Respuesta con sugerencia y línea «Evidencia de herramienta local» con 180 minutos, 144 de enfoque, 36 de descanso y 3 bloques. |
| Datos faltantes | «Ayúdame a organizar el estudio». | Pregunta cuántas horas tiene y qué temas debe estudiar; no inventa cifras. |
| Memoria | Después de la primera prueba, escribir «Cambia el tiempo a 2 horas». | Mantiene referencia a los 4 temas y vuelve a calcular con las 2 horas. |
| Sesión nueva | Pulsar «Nueva sesión» y luego «¿Cuántos temas tenía?». | La conversación anterior desaparece y el agente no debe recordar ese dato. |
| Validación local | Ejecutar pruebas de `CalcularBloques` con 0 horas, 13 horas o 0 temas. | La herramienta devuelve un mensaje de validación y no calcula un plan fuera del rango. |
| Clave ausente | Cerrar la variable `OPENAI_API_KEY` temporalmente o usar un perfil sin esa variable y crear el agente. | Mensaje explica cómo configurar la variable; la clave nunca se muestra en la interfaz. |
| Otro proveedor | Seleccionar Claude, Gemini o Grok. | Mensaje claro: este prototipo conecta únicamente con OpenAI. |

### Cálculo esperado para 3 horas y 4 temas

- Tiempo total: `3 × 60 = 180` minutos.
- Enfoque estimado: `180 × 0.80 = 144` minutos.
- Descansos estimados: `180 − 144 = 36` minutos.
- Promedio de enfoque por tema: `144 ÷ 4 = 36` minutos.
- Bloques de hasta 50 minutos: `techo(144 ÷ 50) = 3`.

## Evaluación: calidad, límites, costo y riesgos

- **Calidad:** revisar que la respuesta use los datos dados, pregunte si falta información, cite el cálculo de la herramienta cuando corresponda y sugiera un plan viable. Repetir las pruebas con distintas cantidades de horas y temas.
- **Límites:** el agente no conoce el plan de estudios, el calendario ni el nivel de dominio de cada materia si no se los dicen. El cálculo reparte por igual el tiempo entre temas; el agente puede recomendar ajustes, pero no debe presentarlos como una verdad académica.
- **Costo aproximado:** GPT-4o mini publica una tarifa de USD 0.15 por millón de tokens de entrada y USD 0.60 por millón de salida. Si una interacción usa aproximadamente 1,500 tokens de entrada y 300 de salida, el cálculo sería cerca de `USD 0.000405` por interacción y `USD 0.0081` por 20 interacciones. El historial de la sesión vuelve a enviarse y puede hacer crecer la entrada; el costo real depende del uso medido por la cuenta.
- **Riesgos:** la consulta e instrucciones viajan al proveedor seleccionado. No introducir información confidencial. La clave se guarda en una variable de entorno de usuario, no en el código ni en `appsettings.json`. La salida del modelo puede equivocarse; verificar los horarios y prioridades antes de seguirla.

## Referencias consultadas

- Microsoft. *OpenAI provider — Microsoft Agent Framework*. https://learn.microsoft.com/en-us/agent-framework/integrations/by-component/model-providers/openai
- Microsoft. *Using function tools with an agent*. https://learn.microsoft.com/en-us/agent-framework/agents/tools/function-tools
- Microsoft. *AgentSession / RunAsync API*. https://learn.microsoft.com/en-us/dotnet/api/microsoft.agents.ai.aiagent.runasync
- NuGet. *Microsoft.Agents.AI.OpenAI 1.21.0*. https://www.nuget.org/packages/Microsoft.Agents.AI.OpenAI
- OpenAI. *GPT-4o mini model and pricing*. https://developers.openai.com/api/docs/models/gpt-4o-mini

Referencias verificadas el 1 de octubre de 2026. Las versiones de paquetes, modelos y precios pueden cambiar.
