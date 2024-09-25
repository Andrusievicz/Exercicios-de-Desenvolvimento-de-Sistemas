using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o ano de nascimento
        Console.Write("Digite o seu ano de nascimento: ");
        int anonascimento = Convert.ToInt32(Console.ReadLine());

        // Obtém o ano atual
        int anoatual = DateTime.Now.Year;

        // Calcula a idade do usuário
        int idade = anoatual - anonascimento;

        // Exibe a idade do usuário
        Console.WriteLine($"Você tem {idade} anos.");
    }
}