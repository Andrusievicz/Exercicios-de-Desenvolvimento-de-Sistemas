using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Cria uma fila para armazenar os nomes
        Queue<string> fila = new Queue<string>();

        // Lê 3 nomes do usuário e os enfileira
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Digite o nome {i + 1}: ");
            string nome = Console.ReadLine();
            fila.Enqueue(nome);
        }

        // Desenfileira e imprime os nomes, um por linha
        Console.WriteLine("\nOs nomes desenfileirados são: ");
        while (fila.Count > 0)
        {
            Console.WriteLine(fila.Dequeue());
        }
        
        Console.ReadKey(); // Pausa o Console

    }
}