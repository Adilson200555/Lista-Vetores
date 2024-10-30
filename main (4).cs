using System;

class Program
{
    static void Main()
    {
        const int maxBases = 50;
        char[] dna = new char[maxBases];
        int n;

        Console.Write("Informe o número de bases (até 50): ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n > maxBases || n < 1)
        {
            Console.WriteLine("Número de bases inválido. Deve ser entre 1 e 50.");
            return;
        }

        Console.WriteLine("Informe as bases do DNA (A, T, C, G):");
        for (int i = 0; i < n; i++)
        {
            char baseEntrada;
            do
            {
                Console.Write($"Base {i + 1}: ");
                baseEntrada = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (baseEntrada != 'A' && baseEntrada != 'T' && baseEntrada != 'C' && baseEntrada != 'G');

            dna[i] = baseEntrada;
        }

        char[] dnaComplementar = new char[n];
        for (int i = 0; i < n; i++)
    
