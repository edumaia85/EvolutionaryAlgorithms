using EvolutionaryAlgorithms;

Console.Write("Digite o número de casas do número binário: ");

int bitCounts = int.Parse(Console.ReadLine());

var individual = new Individual(bitCounts);
individual.FillGeneVector();
individual.GenerateDecimalValue();
individual.NormalizeValue();
individual.FunctionOfX();

Console.WriteLine("------Vetor------");
Console.WriteLine();
for (int i = 0; i < individual.Gene.Length; i++)
{
    Console.Write(individual.Gene[i] + " ");
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Valor decimal: {individual.DecimalValue}");
Console.WriteLine($"Normalizar: {individual.Normalize}");
Console.WriteLine($"F(x): {individual.X}");
