namespace EvolutionaryAlgorithms;

public class AuxIndividual(string gene, int decimalValue, double normalize, double x)
{
    public string Gene { get; set; } = gene;
    public int DecimalValue { get; set; } = decimalValue;
    public double Normalize { get; set; } = normalize;
    public double X { get; set; } = x;
}
