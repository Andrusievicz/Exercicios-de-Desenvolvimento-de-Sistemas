using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main()
    {
        // Cria uma lista de strings representando nomes de pessoas
        List<string> nomes = new List<string> { "Ana", "Bruno", "Amanda", "Carlos", "Arthur", "Beatriz", "Alberto" };

        // Usa LINQ para encontrar nomes que começam com a letra "A" e ordená-los em ordem decrescente
        var nomesComA = nomes
                        .Where(nome => nome.StartsWith("A")) // Filtra nomes que começam com "A"
                        .OrderByDescending(nome => nome);   // Ordena em ordem decrescente

        // Imprime os nomes que começam com "A" em ordem decrescente
        Console.WriteLine("Nomes que começam com a letra 'A', em ordem decrescente: ");
        foreach (string nome in nomesComA)
        {
            Console.WriteLine(nome);
        }
    }
}