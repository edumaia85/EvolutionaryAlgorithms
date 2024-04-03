using EvolutionaryAlgorithms;

var random = new Random();

Console.Write("Digite o número de casas do número binário: ");

int bitCounts = int.Parse(Console.ReadLine());

var individual = new Individual();

var gene = new int[bitCounts];

void FillGeneVector(int[] gene, Random random)
{
    for (int i = 0; i < gene.Length; i++)
    {
        gene[i] = random.Next(0, 2);
    }
}

int GenerateDecimalValue(int[] gene)
{
    int decimalValue = 0;
    int bitPosition = gene.Length - 1;

    for (int i = 0; i < gene.Length; i++)
    {
        decimalValue += gene[i] * (int)Math.Pow(2, bitPosition);
        bitPosition--;
    }

    return decimalValue;
}

double NormalizeValue(int[] gene, int decimalValue)
{
    double normalize = 0;
    double bitLength = Math.Pow(2, gene.Length) - 1;

    double dec = decimalValue;

    normalize = dec / bitLength * 6;

    return normalize;
}

double FunctionOfX(double normalize)
{
    double x = 0;
    x = Math.Pow(normalize, 2) - (5 * normalize) + 6;

    return x;
}

void Mutation(int[] gene)
{
    int switchValue = random.Next(0, gene.Length - 1);
    int newValue = gene[switchValue] == 0 ? 1 : 0;

    gene[switchValue] = newValue;
}

void MutateIndividualAutomatic(int[] gene, Individual individual)
{
    Mutation(gene);
    int decimalValue = GenerateDecimalValue(gene);
    double normalize = NormalizeValue(gene, decimalValue);
    double x = FunctionOfX(normalize);

    if (x < individual.X)
    {
        individual.Gene = string.Join(",", gene);
        individual.DecimalValue = decimalValue;
        individual.Normalize = normalize;
        individual.X = x;
    }
}

FillGeneVector(gene, random);

individual.Gene = string.Join(",", gene);
individual.DecimalValue = GenerateDecimalValue(gene);
individual.Normalize = NormalizeValue(gene, individual.DecimalValue);
individual.X = FunctionOfX(individual.Normalize);

Console.WriteLine("------Cromossomo------");
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

Console.Write("Informe a quantidade de interações que deseja: ");
int loops = int.Parse(Console.ReadLine());

while (loops >= 0)
{
    MutateIndividualAutomatic(gene, individual);

    Console.WriteLine("------Cromossomo------");
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
    loops--;
}