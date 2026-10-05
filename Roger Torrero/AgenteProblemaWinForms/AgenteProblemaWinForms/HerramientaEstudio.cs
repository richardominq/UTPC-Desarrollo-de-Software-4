using System.ComponentModel;

namespace AgenteProblemaWinForms;

/// <summary>
/// Herramienta local y segura: estima la distribución del tiempo de estudio.
/// </summary>
public static class HerramientaEstudio
{
    /// <summary>Guarda evidencia del último cálculo local solicitado por el agente.</summary>
    public static string? UltimaEjecucion { get; private set; }

    public static void LimpiarEvidencia()
    {
        UltimaEjecucion = null;
    }

    [Description("Calcula una distribución orientativa del tiempo de estudio y de los descansos. Úsala cuando la persona indique horas disponibles y cantidad de temas o materias.")]
    public static string CalcularBloques(
        [Description("Horas totales disponibles para estudiar. Debe ser un número entre 0.5 y 12.")]
        double horasDisponibles,
        [Description("Cantidad de temas o materias que se desean repasar. Debe ser un número entero entre 1 y 12.")]
        int cantidadTemas)
    {
        if (double.IsNaN(horasDisponibles) || double.IsInfinity(horasDisponibles) ||
            horasDisponibles < 0.5 || horasDisponibles > 12)
        {
            UltimaEjecucion =
                $"Entrada rechazada: {horasDisponibles} horas. Se aceptan de 0.5 a 12 horas.";
            return "No se pudo calcular: las horas deben estar entre 0.5 y 12.";
        }

        if (cantidadTemas < 1 || cantidadTemas > 12)
        {
            UltimaEjecucion =
                $"Entrada rechazada: {cantidadTemas} temas. Se acepta de 1 a 12 temas.";
            return "No se pudo calcular: la cantidad de temas debe estar entre 1 y 12.";
        }

        int minutosTotales = (int)Math.Round(horasDisponibles * 60, MidpointRounding.AwayFromZero);
        int minutosEnfoque = (int)Math.Round(minutosTotales * 0.80, MidpointRounding.AwayFromZero);
        int minutosDescanso = minutosTotales - minutosEnfoque;
        int minutosPorTema = minutosEnfoque / cantidadTemas;
        int bloquesDeHasta50Minutos = (int)Math.Ceiling(minutosEnfoque / 50.0);

        string resultado =
            $"Tiempo disponible: {minutosTotales} minutos. " +
            $"Enfoque estimado (80%): {minutosEnfoque} minutos. " +
            $"Descansos estimados (20%): {minutosDescanso} minutos. " +
            $"Temas: {cantidadTemas}; promedio de enfoque por tema: {minutosPorTema} minutos. " +
            $"Bloques de enfoque de hasta 50 minutos: {bloquesDeHasta50Minutos}. " +
            "Es una estimación orientativa; la persona debe ajustar el plan a la dificultad y prioridad de cada tema.";

        UltimaEjecucion =
            $"Entradas: {horasDisponibles:0.##} horas y {cantidadTemas} temas. " +
            $"Resultado local: {minutosEnfoque} minutos de enfoque, {minutosDescanso} minutos de descanso " +
            $"y {bloquesDeHasta50Minutos} bloques estimados.";

        return resultado;
    }
}
