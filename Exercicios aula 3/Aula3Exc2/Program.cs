using System;

class Program
{
    static void Main()
    {
        //declarações das variaveis
        double soma, subtracao, multiplicacao, divisao;

        //pedindo ao usuario o valor das variaveis
        Console.Write("Digite o primeiro numero:");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo numero:");
        double num2 = double.Parse(Console.ReadLine());

        //definiçoes dos calculos das variaveis
        soma = num1 + num2;
        subtracao = num1 - num2;
        multiplicacao = num1 * num2;
        divisao = num1 / num2;

        //mostrando o resultados
        Console.WriteLine($"A soma dos numeros é {soma}, a subtração {subtracao}, a multiplicação {multiplicacao} e a divisao {divisao}");
    }
}