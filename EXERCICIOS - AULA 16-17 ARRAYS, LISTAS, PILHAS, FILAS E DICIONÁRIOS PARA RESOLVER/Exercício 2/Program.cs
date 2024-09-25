using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Cria uma lista para armazenar os nomes
        List<string> nomes = new List<string>();

        // Lê 5 nomes do usuário e adiciona à lista
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o nome {i + 1}: ");
            string nome = Console.ReadLine();
            nomes.Add(nome);
        }

        // Imprime todos os nomes da lista, um por linha
        Console.WriteLine("\nOs nomes digitados são: ");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        
        Console.ReadKey(); // Pausa o Console

    }
}