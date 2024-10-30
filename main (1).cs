using System;

class Program
{
    static int SomaVetor(int[] vetor)
    {
        int soma = 0;
        foreach (int numero in vetor)
        {
            soma += numero;
        }
        return soma;
    }

    static void Main()
    {
        Console.Write("Informe o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Informe o elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        int soma = SomaVetor(vetor);
        Console.WriteLine($"A soma dos elementos do vetor é: {soma}");
    }
}
