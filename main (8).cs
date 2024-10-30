using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o tamanho do vetor: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] vetor = new int[n];

        Console.WriteLine("Preencha o vetor de inteiros:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Digite um valor para verificar quantas vezes aparece no vetor: ");
        int valorProcurado = Convert.ToInt32(Console.ReadLine());

        int contador = 0;
        foreach (int elemento in vetor)
        {
            if (elemento == valorProcurado)
            {
                contador++;
            }
        }

        Console.WriteLine($"O valor {valorProcurado} aparece {contador} vez(es) no vetor.");
        Console.WriteLine("Elementos do vetor:");
        Console.WriteLine(string.Join(", ", vetor));
    }
}
