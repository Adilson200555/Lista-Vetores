using System;

class Program
{
    static double EncontrarMaior(double[] vetor)
    {
        double maior = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }
        return maior;
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

        double maior = EncontrarMaior(vetor);
        Console.WriteLine($"O maior elemento do vetor é: {maior}");
    }
}
