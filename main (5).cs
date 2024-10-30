using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe a quantidade de números a serem sorteados: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int[] numeros = new int[n];

        for (int i = 0; i < n; i++)
        {
            numeros[i] = random.Next(1, 101);
        }

        Console.WriteLine("Números sorteados: " + string.Join(", ", numeros));

        Console.Write("Digite um número para verificar se está no vetor: ");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());

        int posicao = Array.IndexOf(numeros, numeroDigitado);
        if (posicao != -1)
        {
            Console.WriteLine($"O número {numeroDigitado} está na posição {posicao}.");
        }
        else
        {
            Console.WriteLine($"O número {numeroDigitado} não está no vetor.");
        }
    }
}


    
