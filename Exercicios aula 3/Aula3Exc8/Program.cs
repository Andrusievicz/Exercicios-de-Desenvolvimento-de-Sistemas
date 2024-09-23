using System;

class Program
{
    static void Main()
    {
        // solicita a entrada de valor do usuário
        Console.Write("Digite um valor em reais(BRL) para ser convertido em dólares americanos(USD): ");
        double brl = double.Parse(Console.ReadLine());

        // define a conversão
        double usd = brl * 0.1781;

        // exibe os resultados
        Console.WriteLine($"O valor em doláres americanos(USD) é de: {usd}");
    }
}