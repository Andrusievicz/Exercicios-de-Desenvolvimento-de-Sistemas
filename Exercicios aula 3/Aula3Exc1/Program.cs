using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        //declaração das variaveis
        string nome;
        int idade;

        //pedir ao usuario que digite seu nome
        Console.WriteLine("Digite seu nome:");
        nome = Console.ReadLine();

        //pedir ao usuario que digite sua idade
        Console.WriteLine("Digite sua idade:");
        idade = int.Parse(Console.ReadLine());

        //mostrando os resultados
        Console.WriteLine($"Seu nome é {nome} e sua idade é {idade} ");
    }
}