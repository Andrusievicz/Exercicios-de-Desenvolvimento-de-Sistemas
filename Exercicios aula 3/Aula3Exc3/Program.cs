using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira a temperatura em Celsius
        Console.WriteLine("Digite a temperatura em Celcius para converter em Farenheit");
        double celcius = double.Parse(Console.ReadLine());

        // Converte a temperatura de Celsius para Fahrenheit
        double farenheit = (celcius * 1.8 + 32);

        // Exibe a temperatura em Fahrenheit
        Console.WriteLine($"A temperatura em Farenheit é: {farenheit}");

    }
}