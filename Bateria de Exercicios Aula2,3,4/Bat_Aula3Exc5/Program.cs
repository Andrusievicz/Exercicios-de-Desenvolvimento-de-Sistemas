using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número inteiro
        Console.Write("Digite um número inteiro: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Verifica se o número é par ou ímpar
        if (num % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}