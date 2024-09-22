using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira a quantidade de números 
        Console.WriteLine("Digite a quantidade de números desejada");
        int tamanho = Convert.ToInt32(Console.ReadLine());

        int[] numeros = new int[tamanho];

        // Solicita ao usuário que insira os números
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite os números: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Ordena o array em ordem crescente
        ordenarArray(numeros);

        // Exibe o array ordenado
        Console.WriteLine("Os numeros digitados ordenados são: ");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
    }
    // Método para ordenar um array de inteiros em ordem crescente
    static void ordenarArray(int[] array)
    {
        Array.Sort(array);
    }
}