using Microsoft.Extensions.AI;

namespace AgenteProblemaWinForms;

public sealed class UsageMeter
{
    public long InputTokens { get; private set; }
    public long OutputTokens { get; private set; }
    public int CompletedRuns { get; private set; }
    public int RunsWithoutUsage { get; private set; }

    public void Add(UsageDetails? usage)
    {
        CompletedRuns++;
        if (usage?.InputTokenCount is not long input || usage.OutputTokenCount is not long output)
        {
            RunsWithoutUsage++;
            return;
        }
        InputTokens += Math.Max(0, input);
        OutputTokens += Math.Max(0, output);
    }

    // La tarifa se expresa en USD por millón de tokens; el caché no se descuenta.
    public decimal Estimate(decimal inputRate, decimal outputRate) =>
        (InputTokens * inputRate + OutputTokens * outputRate) / 1_000_000m;
}
