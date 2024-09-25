using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o primeiro número
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        // Solicita ao usuário que insira o segundo número
        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        // Calcula a soma dos dois números
        double soma = num1 + num2;

        // Exibe a soma dos dois números
        Console.WriteLine($"A soma de {num1} e {num2} é: {soma}");
    }
}