using System;

class Program
{
    static void Main()
    {
        double nota1, nota2, peso1, peso2, mediaPonderada;

        Console.WriteLine("Digite a nota da primeira prova:");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o peso da primeira prova:");
        peso1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota da segunda prova:");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o peso da segunda prova:");
        peso2 = double.Parse(Console.ReadLine());

        mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

        Console.WriteLine($"A media ponderada das provas é: {mediaPonderada:F2}");
    }
}