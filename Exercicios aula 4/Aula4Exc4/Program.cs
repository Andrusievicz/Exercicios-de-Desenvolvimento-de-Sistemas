using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número inteiro positivo
        Console.Write("Digite um número inteiro posivito: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0 )
        {
            Console.WriteLine("Erro: O número deve ser um inteiro posivito.");
        }
        else
        {
            // Calcula o fatorial do número
            long fatorial = CalcularFatorial(num);

            // Exibe o resultado
            Console.WriteLine($"O fatorial de {num} é {fatorial}");
        }
    }

    // Função para calcular o fatorial de um número inteiro positivo
    static long CalcularFatorial(int num)
    {
        long fatorial = 1;
        for (int i = 1;  i <= num; i++)
        {
            fatorial *= i;
        }
        return fatorial;
    }
}