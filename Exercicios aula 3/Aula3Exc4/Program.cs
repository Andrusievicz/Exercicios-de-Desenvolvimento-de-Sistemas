using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira uma frase
        Console.Write("Digite uma frase:");
        string frase = Console.ReadLine();

        // Calcula o número de caracteres na frase
        int num_caracteres = frase.Length;

        // Converte a frase para maiúsculas
        string frase_maiuscula = frase.ToUpper();

        // Inverte a frase
        char[] array_caracteres = frase.ToCharArray();
        Array.Reverse(array_caracteres);
        string frase_invertida = new string(array_caracteres);

        // Exibe os resultados
        Console.WriteLine($"Numero de caracteres: {num_caracteres}");
        Console.WriteLine($"Frase maiúscula: {frase_maiuscula}");
        Console.WriteLine($"Frase invertida: {frase_invertida}");
    }
}