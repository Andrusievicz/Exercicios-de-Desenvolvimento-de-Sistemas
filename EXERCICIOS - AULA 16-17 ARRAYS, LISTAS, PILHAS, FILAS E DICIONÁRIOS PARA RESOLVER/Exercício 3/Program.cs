using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Cria uma pilha para armazenar os números inteiros
        Stack<int> pilha = new Stack<int>();

        // Lê 3 números inteiros do usuário e empilha-os
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());
            pilha.Push(numero);
        }

        // Desempilha e imprime os números, um por linha
        Console.WriteLine("\nOs números desempilhados são: ");
        while (pilha.Count > 0)
        {
            Console.WriteLine(pilha.Pop());
        }

        Console.ReadKey(); // Pausa o Console

    }
}