using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número inteiro
        Console.Write("Digite um número inteiro: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Chama o método para verificar se o número é primo
        bool primo = Primo(num);

        // Exibe o resultado
        if (primo)
        {
            Console.WriteLine($"O número {num} é primo.");
        }
        else
        {
            Console.WriteLine($"O número {num} não é primo.");
        }
    }
    // Método que recebe um número inteiro e retorna se ele é primo
    static bool Primo(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}