using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o número de lançamentos do dado: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] resultados = new int[n];

        Console.WriteLine("Informe os resultados dos lançamentos (números de 1 a 6):");
        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.Write($"Lançamento {i + 1}: ");
                resultados[i] = Convert.ToInt32(Console.ReadLine());
            } while (resultados[i] < 1 || resultados[i] > 6);
        }

        int[] ocorrencias = new int[6];

        foreach (int resultado in resultados)
        {
            ocorrencias[resultado - 1]++;
        }

        Console.WriteLine("Ocorrências de cada face do dado:");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Face {i + 1}: {ocorrencias[i]} vez(es)");
        }
    }
}
