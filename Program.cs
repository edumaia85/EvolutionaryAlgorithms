using System.Collections;
using EvolutionaryAlgorithms;

Console.Write("Digite o número de casas do número binário: ");

int bitCounts = int.Parse(Console.ReadLine());

var individual = new Individual(bitCounts);
List<AuxIndividual> auxIndividuals = [];

int loops = 3;

while(loops >= 0) {
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
    AuxIndividual novoAuxIndividual = new(
    string.Join(", ", individual.Gene),
    individual.DecimalValue,
    individual.Normalize,
    individual.X);

    auxIndividuals.Add(novoAuxIndividual);
    loops--;
}

foreach(AuxIndividual auxIndividual in auxIndividuals)
{
    Console.WriteLine($"Gene: {auxIndividual.Gene}");
    Console.WriteLine($"Valor decimal: {auxIndividual.DecimalValue}");
    Console.WriteLine($"Normalizar: {auxIndividual.Normalize}");
    Console.WriteLine($"F(x): {auxIndividual.X}");
}