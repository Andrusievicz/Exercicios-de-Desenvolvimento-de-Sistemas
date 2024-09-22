using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número inteiro
        Console.WriteLine("Digite um numero inteiro: ");
        int num = Convert.ToInt32 (Console.ReadLine());

        // Verifica se o número é primo
        bool ehprimo = VerificarPrimo(num);

        // Exibe o resultado
        if (ehprimo)
        {
            Console.WriteLine($"{num} é um número primo.");
        }
        else
        {
            Console.WriteLine($"{num} não é um número primo");
        }
    }
    // Método para verificar se um número é primo
    static bool VerificarPrimo(int num)
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