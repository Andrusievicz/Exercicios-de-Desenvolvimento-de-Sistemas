using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o salario base do vendedor:");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o total de vendas do vendedor:");
        double totalVendas = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a porcentagem de comissao (em %):");
        double percentualComissao = double.Parse(Console.ReadLine());

        double comissao = (percentualComissao / 100) * totalVendas;

        double salarioTotal = salarioBase + comissao;

        Console.WriteLine($"Salario base: {salarioBase:C}");
        Console.WriteLine($"Comissao: {comissao:C}");
        Console.WriteLine($"Salario total: {salarioTotal:C}");
    }
}