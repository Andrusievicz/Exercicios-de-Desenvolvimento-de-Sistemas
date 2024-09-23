using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuario que digite um nome
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();

        // Solicita ao usuario que digite o preço
        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());

        // Solicita ao usuario que digite a quantidade
        Console.Write("Digite a quantidade do produto: ");
        double qnt = double.Parse(Console.ReadLine());

        // Exibe os resultados
        Console.WriteLine($"O nome do produto é {nome}, o preço é R${preco} e a quantidade é {qnt}");
    }
}