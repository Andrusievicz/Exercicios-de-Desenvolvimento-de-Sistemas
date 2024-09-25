using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que digite seu nome
        Console.Write("Por favor, digite seu nome: ");
        
        string nome = Console.ReadLine();

        // Exibe uma mensagem de saudação personalizada
        Console.WriteLine($"Olá {nome}! Seja bem-vindo(a)!");
    }
}