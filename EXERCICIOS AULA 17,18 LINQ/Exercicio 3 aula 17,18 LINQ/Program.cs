using System;
using System.Collections.Generic;
using System.Linq;

class Program()
{
    static void Main()
    {
        // Cria um dicionário onde a chave é um número e o valor é uma string
        Dictionary<int, string> dicionario = new Dictionary<int, string>()
        {
            {1, "Banana" },
            {2, "Pera" },
            {3, "Maçã" },
            {4, "Abacate" },
            {5, "Melancia" },
        };

        // Usa LINQ para encontrar todas as entradas onde o valor contém a letra "e" e ordenar os resultados pela chave
        var resultado = dicionario
                        .Where(par => par.Value.Contains("e")) // Filtra as entradas onde o valor contém a letra "e"
                        .OrderBy(par => par.Key);              // Ordena os resultados pela chave

        // Imprime as entradas encontradas
        Console.WriteLine("Entradas onde o valor contém a letra 'e', ordenadas pela chave: ");
        foreach (var par in resultado)
        {
            Console.WriteLine($"Chave: {par.Key}, Valor: {par.Value}.");
        }
    }
}