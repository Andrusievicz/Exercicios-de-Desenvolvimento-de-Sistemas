using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira a quantidade de números na lista
        Console.Write("Digite a quantidade de números na lista: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        // Cria uma lista para armazenar os números
        List<int> numeros = new List<int>();

        // Solicita ao usuário que insira os números
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Digite o número {i+1}: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numeros.Add(numero);
        }

        // Chama o método para calcular a média dos números na lista
        double media = CalcularMedia(numeros);

        // Exibe a média dos números
        Console.WriteLine($"A média dos números é : {media}");
    }
    // Método que calcula a média de uma lista de números inteiros
    static double CalcularMedia(List<int> numeros)
    {
        if (numeros.Count == 0)
        {
            return 0;
        }

        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }

        return (double)soma/ numeros.Count;
    }
}