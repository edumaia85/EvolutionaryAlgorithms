namespace EvolutionaryAlgorithms;

public class Individual
{
    public Individual()
    {
        
    }

    public Individual(string gene, int decimalValue, double normalize, double x) {
        Gene = gene;
        DecimalValue = decimalValue;
        Normalize = normalize;
        X = x;
    }
    
    public string Gene { get; set; } = string.Empty;
    public int DecimalValue { get; set; }
    public double Normalize { get; set; }
    public double X { get; set; }
}
