using System;

class Program
{
    static int ContarImpares(int[] vetor)
    {
        int contador = 0;
        foreach (int numero in vetor)
        {
            if (numero % 2 != 0)
            {
                contador++;
            }
        }
        return contador;
    }

    static void Main()
    {
        Console.Write("Informe o tamanho do vetor: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] vetor = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Informe o elemento {i + 1}: ");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        int quantidadeImpares = ContarImpares(vetor);
        Console.WriteLine($"A quantidade de valores ímpares no vetor é: {quantidadeImpares}");
    }
}
