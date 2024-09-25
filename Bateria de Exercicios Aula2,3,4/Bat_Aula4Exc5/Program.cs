using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira uma string
        Console.Write("Digite uma frase: ");
        string input = Console.ReadLine();

        // Chama o método para inverter a string
        string invertida = InverterString(input);

        // Exibe a string invertida
        Console.WriteLine($"A frase invertida é: {invertida}");
    }
    // Método que inverte uma string
    static string InverterString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }
}