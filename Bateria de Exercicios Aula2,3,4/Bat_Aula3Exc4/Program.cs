using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira uma temperatura em Celsius
        Console.Write("Digite a temperatura em Celcius: ");
        double celcius = double.Parse(Console.ReadLine());

        // Converte a temperatura de Celsius para Fahrenheit
        double fahrenheit = (celcius * 9 / 5) + 32;

        // Exibe a temperatura convertida em Fahrenheit
        Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");
    }
}