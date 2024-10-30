using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a mensagem codificada:");
        string mensagemCodificada = Console.ReadLine();
        StringBuilder mensagemDecodificada = new StringBuilder();

        for (int i = 0; i < mensagemCodificada.Length; i++)
        {
            if (mensagemCodificada[i] == 'p' && i + 1 < mensagemCodificada.Length)
            {
                mensagemDecodificada.Append(mensagemCodificada[i + 1]);
                i++; // Pular a próxima letra, já que é a letra decodificada
            }
     
