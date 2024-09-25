using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número inteiro que não seja negativo
        Console.Write("Digite um número inteiro que não seja negativo: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("O número não pode ser negativo");
        }
        else
        {
            // Chama o método para calcular o fatorial do número
            long fatorial = CalcularFatorial(num);

            // Exibe o resultado
            Console.WriteLine($"O fatorial de {num} é: {fatorial}");
        }
    }
    // Método que calcula o fatorial de um número inteiro que não seja negativo
    static long CalcularFatorial(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }

        long fatorial = 1;
        for (int i = 2; i <= num; i++)
        {
            fatorial *= i;
        }

        return fatorial;
    }
}