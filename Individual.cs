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
        DecimalValue = 0;
        int bitPosition = Gene.Length - 1;

        for(int i = 0; i < Gene.Length; i++)
        {
            DecimalValue += Gene[i] * (int)Math.Pow(2, bitPosition);
            bitPosition--;
        }
    }

    public void NormalizeValue()
    {
        Normalize = 0;
        double bitLength = Math.Pow(2, Gene.Length) - 1;

        double dec = DecimalValue;

        Normalize = dec / bitLength * 6;
    }

    public void FunctionOfX()
    {
        X = 0;
        X = Math.Pow(Normalize, 2) - (5 * Normalize) + 6;
    }

    public void Mutation()
    {
        var random = new Random();

        int switchValue = random.Next(0, Gene.Length - 1);

        int newValue = Gene[switchValue] == 0 ? 1 : 0;

        Gene[switchValue] = newValue;
    }
}
