using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Cria um array de números inteiros
        int[] numeros = { 5, 2, 8, 3, 7, 4, 10, 1, 6, 9 };

        // Usa LINQ para encontrar todos os números pares e ordená-los em ordem crescente
        var numerosParesOrdenados = numeros
                                    .Where(n => n % 2 == 0) // Filtra apenas os números pares
                                    .OrderBy(n => n);        // Ordena em ordem crescente

        // Imprime os números pares ordenados
        Console.WriteLine("Números pares ordenados em ordem crescente: ");
        foreach (int numero in numerosParesOrdenados)
        {
            Console.WriteLine(numero);
        }
    }
}