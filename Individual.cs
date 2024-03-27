namespace EvolutionaryAlgorithms;

public class Individual(int bitsCount)
{
    public int[] Gene { get; set; } = new int[bitsCount];
    public int DecimalValue { get; set; }
    public double Normalize { get; set; }
    public double X { get; set; }

    public void FillGeneVector()
    {
        var random = new Random();

        for (int i = 0; i < Gene.Length; i++)
        {
            Gene[i] = random.Next(0, 2);
        }
    }

    public void GenerateDecimalValue()
    {
        int bitPosition = Gene.Length - 1;

        for(int i = 0; i < Gene.Length; i++)
        {
            DecimalValue += Gene[i] * (int)Math.Pow(2, bitPosition);
            bitPosition--;
        }
    }

    public void NormalizeValue()
    {
        double bitLength = Math.Pow(2, Gene.Length) - 1;

        double dec = DecimalValue;

        Normalize = dec / bitLength * 6;
    }

    public void FunctionOfX()
    {
        X = Math.Pow(Normalize, 2) - (5 * Normalize) + 6;
    }
}
