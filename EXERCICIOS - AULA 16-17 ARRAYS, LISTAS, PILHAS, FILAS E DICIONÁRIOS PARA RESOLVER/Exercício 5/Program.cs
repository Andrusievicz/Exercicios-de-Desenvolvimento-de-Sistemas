using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Cria um dicionário para armazenar os pares chave-valor
        Dictionary<int, string> dicionario = new Dictionary<int, string>();

        // Adiciona 3 pares chave-valor ao dicionário
        dicionario.Add(1, "Primeiro");
        dicionario.Add(2, "Segundo");
        dicionario.Add(3, "Terceiro");

        // Imprime todos os pares chave-valor
        Console.WriteLine("Os pares chave-valor no dicionario são: ");
        foreach (KeyValuePair<int, string> par in dicionario)
        {
            Console.WriteLine($"Chave: {par.Key}, Valor: {par.Value}");
        }

        Console.ReadKey(); // Pausa o Console

    }
}