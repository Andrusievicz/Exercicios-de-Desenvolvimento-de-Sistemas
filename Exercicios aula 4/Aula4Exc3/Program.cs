using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que escolha a conversão desejada
        Console.WriteLine("Escolha a conversão desejada");
        Console.WriteLine("[1] Celcius para Fahrenheit");
        Console.WriteLine("[2] Fahrenheit para Celcius");

        int escolha = Convert.ToInt32(Console.ReadLine());

        // Variável para armazenar a temperatura convertida
        double temperaturaConvertida;

        if (escolha == 1)
        {
            // Solicita ao usuário que insira a temperatura em Celsius
            Console.Write("Digite a temperatura em Celcius:");
            double celcius = double.Parse(Console.ReadLine());

            // Converte de Celsius para Fahrenheit
            temperaturaConvertida = CelciusParaFarenheit(celcius);

            // Exibe a temperatura convertida
            Console.WriteLine($"A temperatura em Fahrenheit é {temperaturaConvertida}");
        }
        else if (escolha == 2)
        {
            // Exibe a temperatura convertida
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            // Converte de Fahrenheit para Celsius
            temperaturaConvertida = FarenheitParaCelcius(fahrenheit);

            // Exibe a temperatura convertida
            Console.WriteLine($"A temperatura em Celcius é: {temperaturaConvertida}");
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }

    // Método para converter de Celsius para Fahrenheit
    static double CelciusParaFarenheit (double celcius)
    {
        return (celcius * 9 / 5) + 32;
    }
    // Método para converter de Fahrenheit para Celsius
    static double FarenheitParaCelcius (double farenheit)
    {
        return (farenheit - 32) * 5 / 9;
    }
}