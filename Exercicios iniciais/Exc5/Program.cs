using System;

class Program
{
    static void Main()
    {
        double numero1, numero2, soma, subtracao, multiplicacao, divisao;

        Console.WriteLine("Digite o primeiro numero:");
        numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero:");
        numero2 = double.Parse(Console.ReadLine());

        soma = numero1 + numero2;
        subtracao = numero1 - numero2;
        multiplicacao = numero1 * numero2;
        divisao = numero1 / numero2;

        Console.WriteLine($"A soma dos numeros é: {soma:F2}");
        Console.WriteLine($"A subtracao dos numeros é: {subtracao:F2}");
        Console.WriteLine($"A multiplicacao dos numeros é: {multiplicacao:F2}");
        Console.WriteLine($"A divisao dos numeros é: {divisao:F2}");
    }
}