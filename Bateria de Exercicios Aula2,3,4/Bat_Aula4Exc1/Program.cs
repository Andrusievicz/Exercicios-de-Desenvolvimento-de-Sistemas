using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o primeiro número inteiro
        Console.Write("Digite o primeiro número inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Solicita ao usuário que insira o segundo número inteiro
        Console.Write("Digite o segundo número inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Chama o método para calcular a soma dos dois números e armazena o resultado
        int soma = Somar(num1, num2);

        // Exibe a soma dos dois números
        Console.WriteLine($"A soma de {num1} e {num2} é: {soma}");
    }
    // Método que recebe dois números inteiros e retorna a soma deles
    static int Somar(int a, int b)
    {
        return a + b;
    }
}