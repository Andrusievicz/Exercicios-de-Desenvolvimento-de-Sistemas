using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número
        Console.Write("Digite um numero: ");
        double num = double.Parse(Console.ReadLine());

        // Verifica se o número é par ou ímpar
        if (num % 2 == 0)
        {
            Console.WriteLine($"O número {num} é par.");
        }
        else
        {
            Console.WriteLine($"O número {num} é ímpar.");
        }
    }
}