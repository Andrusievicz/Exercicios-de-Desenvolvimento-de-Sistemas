using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número
        Console.WriteLine("Digite um numero");
        double numero = double.Parse(Console.ReadLine());
        
        // Verifica se o número é positivo, negativo ou zero e exibe a mensagem correspondente
        if (numero > 0)
        {
            Console.WriteLine("O numero é positivo.");
        }
        if (numero < 0)
        {
            Console.WriteLine("O numero é negativo.");
        }
        else
        {
            Console.WriteLine("O numero é zero.");
        }
    }
}