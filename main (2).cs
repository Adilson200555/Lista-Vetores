using System;

class Program
{
    static double EncontrarMenor(double[] vetor)
    {
        double menor = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }
        return menor;
    }

    static void Main()
    {
        Console.Write("Informe o tamanho do vetor: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] vetor = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Informe o elemento {i + 1}: ");
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Os elementos do vetor são:");
        foreach (double numero in vetor)
        {
            Console.WriteLine(numero);
        }

        double menor = EncontrarMenor(vetor);
        Console.WriteLine($"O menor elemento do vetor é: {menor}");
    }
}
