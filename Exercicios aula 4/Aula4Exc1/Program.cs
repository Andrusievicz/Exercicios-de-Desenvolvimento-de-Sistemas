using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira dois números
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número :");
        double num2 = double.Parse(Console.ReadLine());

        // Solicita ao usuário que insira a operação desejada
        Console.Write("Digite a operação desejada (+, -, * ou /): ");
        char operacao = Convert.ToChar(Console.ReadLine());

        // Realiza a operação escolhida e exibe o resultado
        double resultado = 0;
        bool operacaoValida = true;

        switch (operacao)
        {
            case '+':
                resultado = Adicionar(num1, num2);
                break;

            case '-':
                resultado = Subtrair(num1, num2);
                break;
            case '*':
                resultado = Multiplicar(num1, num2);
                break;
            case '/':
                if (num1 == 0)
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    operacaoValida = false;
                }
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    operacaoValida = false;
                }   
                else
                {                   
                    resultado = Dividir(num1, num2);
                }
                break;
            default:
                Console.WriteLine("Erro: Operação inválida.");
                operacaoValida = false;
                break;
        }
        if (operacaoValida)
        {
            Console.WriteLine($"O resultado da operação é: {resultado}");
        }
    }
    // Método para adição
    static double Adicionar (double num1, double num2)
    {
        return num1 + num2;
    }
    // Método para subtração
    static double Subtrair (double num1, double num2)
    {
        return num1 - num2;
    }
    // Método para multiplicação
    static double Multiplicar (double num1, double num2)
    {
        return num1 * num2;
    }
    // Método para divisão
    static double Dividir (double num1, double num2)
    {
        return num1 / num2;
    }

}