using System;

class Program
{
    static void Main()
    {
        // Cria um array para armazenar 5 números inteiros
        int[] numeros = new int[5];

        // Lê os 5 números inteiros do usuário
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Imprime o array na ordem inversa
        Console.WriteLine("\nOs números na ordem inversa são: ");
        for (int i = 4; i >= 0; i--)
        {
            Console.Write($"\n {numeros[i]}");           
        }
        Console.ReadKey(); // Pausa o console
    }
}