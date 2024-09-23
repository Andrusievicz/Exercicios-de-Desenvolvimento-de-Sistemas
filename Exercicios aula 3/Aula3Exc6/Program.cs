using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira três números
        Console.WriteLine("Digite três numeros para a média aritmética separado por espaço:");
        string input = Console.ReadLine();

        // Divide a entrada em três partes
        string[] numeros = input.Split(' ');

        // Converte as partes para números de ponto flutuante
        double num1 = double.Parse(numeros[0]);
        double num2 = double.Parse(numeros[1]);
        double num3 = double.Parse(numeros[2]);

        // Realiza a operação artimética
        double media = (num1 + num2 + num3) / 3;

        // Exibe os resultados
        Console.WriteLine($"A média aritmética é {media}");
    }
}