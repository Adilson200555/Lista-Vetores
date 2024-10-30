using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite as cinco notas (de 5.0 a 10.0):");
        string input = Console.ReadLine();
        
        decimal[] notas = input.Split(' ')
                               .Select(decimal.Parse)
                               .ToArray();

        Array.Sort(notas);
        
        decimal notaFinal = notas[1] + notas[2] + notas[3];

        Console.WriteLine($"Nota final: {notaFinal:F1}");
    }
}
