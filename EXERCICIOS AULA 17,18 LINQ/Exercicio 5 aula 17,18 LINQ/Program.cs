using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Cria uma lista de números inteiros
        List<int> numeros = new List<int> { 5, 12, 7, 25, 10, 3, 18 };

        // Usa LINQ para encontrar todos os números maiores que 10, multiplicar cada um por 2 e retornar a lista resultante
        var numerosMultiplicados = numeros
                                   .Where(n => n > 10)    // Filtra os números maiores que 10
                                   .Select(n => n * 2)    // Multiplica cada número por 2
                                   .ToList();             // Converte o resultado para uma lista

        // Imprime a lista resultante
        Console.WriteLine("Números maiores que 10, multiplicados por 2: ");
        foreach (int numero in numerosMultiplicados)
        {
            Console.WriteLine(numero);
        }
    }
}