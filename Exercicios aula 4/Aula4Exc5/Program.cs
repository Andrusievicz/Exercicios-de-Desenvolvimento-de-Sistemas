using System;
using System.Linq;
class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira uma string
        Console.Write("Digite uma frase ou uma palavra: ");
        string entrada = Console.ReadLine();

        // Verifica se a string é um palíndromo
        bool palindromo = verificarpalindromo(entrada);

        // Exibe o resultado
        if (palindromo)
        {
            Console.WriteLine("A frase ou palavra é um palíndromo!");
        }
        else
        {
            Console.WriteLine("A frase ou palavra não é um palíndromo!");
        }
    }
    // Função para verificar se uma string é um palíndromo
    static bool verificarpalindromo(string texto)
    {
        // Remove espaços, pontuação e converte para minúsculas
        string textolimpo = new string(texto.Where(char.IsLetterOrDigit).ToArray()).ToLower();

        // Verifica se o texto limpo é igual ao seu reverso
        string textoreverso = new string(textolimpo.Reverse().ToArray());
        return textolimpo == textoreverso;
    }
}