using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o numerador da primeira fração:");
        int numerador1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o denominador da primeira fração:");
        int denominador1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o numerador da segunda fração:");
        int numerador2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o denominador da segunda fração:");
        int denominador2 = int.Parse(Console.ReadLine());

        int produtoNumerador = numerador1 * numerador2;
        int produtoDenominador = denominador1 * denominador2;

        int somaNumerador = numerador1 * denominador2 + numerador2 * denominador1;
        int somaDenominador = denominador1 * denominador2;

        Simplificar(ref somaNumerador, ref somaDenominador);
        Simplificar(ref produtoNumerador, ref produtoDenominador);

        Console.WriteLine($"Produto: {produtoNumerador}/{produtoDenominador}");
        Console.WriteLine($"Soma: {somaNumerador}/{somaDenominador}");
    }

    static void Simplificar(ref int numerador, ref int denominador)
    {
        int gcd = MDC(numerador, denominador);
        numerador /= gcd;
        denominador /= gcd;

    }

    static int MDC(int a, int b)
    {
        while (b != 0) 

        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;

    }
}