using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;
using OpenAI;

namespace AgenteProblemaWinForms;

/// <summary>
/// Crea el agente de estudio. Este prototipo conecta únicamente con OpenAI.
/// </summary>
public static class AgentFactory
{
    private const string Modelo = "gpt-4o-mini";

    public static AIAgent Crear(string proveedor, string problema, string instrucciones)
    {
        if (!string.Equals(proveedor, "OpenAI", StringComparison.OrdinalIgnoreCase))
        {
            throw new NotSupportedException(
                "Este prototipo tiene OpenAI como único proveedor conectado. " +
                "Los otros proveedores aparecen en la lista para mantener el diseño solicitado.");
        }

        string apiKey = ObtenerClave("OPENAI_API_KEY");

        string instruccionesCompletas = $"""
            Nombre del agente: PlanificaUTP

            Problema que atiende:
            {problema.Trim()}

            Instrucciones del estudiante:
            {instrucciones.Trim()}
            """;

        var cliente = new OpenAIClient(apiKey);
        var chatClient = cliente.GetChatClient(Modelo);

        // La función es código local del proyecto. Solo realiza cálculos;
        // no abre archivos, sitios web ni ejecuta acciones externas.
        var herramientas = new List<AITool>
        {
            AIFunctionFactory.Create(HerramientaEstudio.CalcularBloques)
        };

        return chatClient.AsAIAgent(
            name: "PlanificaUTP",
            instructions: instruccionesCompletas,
            tools: herramientas);
    }

    private static string ObtenerClave(string nombreVariable)
    {
        string? apiKey = Environment.GetEnvironmentVariable(nombreVariable);

        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new InvalidOperationException(
                $"No se encontró {nombreVariable}. Configúrala en Windows y vuelve a abrir Visual Studio.");
        }

        return apiKey;
    }
}
