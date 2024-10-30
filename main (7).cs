using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o tamanho do vetor: ");
        int n = Convert.ToInt32(Console.ReadLine());

        char[] vetor = new char[n];

        Console.WriteLine("Preencha o vetor de caracteres:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor[i] = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        Console.WriteLine("O vetor em ordem inversa é:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(vetor[i]);
        }
        Console.WriteLine();
    }
}
