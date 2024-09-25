using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o primeiro número
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        // Solicita ao usuário que insira o segundo número
        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Solicita ao usuário que insira a operação desejada
        Console.Write("Digite a operação desejada (+, -, *, /): ");
        char operacao = Convert.ToChar(Console.ReadLine());

        // Variável para armazenar o resultado
        double resultado = 0;
        bool operacaoValida = true;

        // Realiza a operação escolhida e exibe o resultado
        switch (operacao)
        {
            case '+':
                resultado = Adicionar(numero1, numero2);
                break;
            case '-':
                resultado = Subtrair(numero1, numero2);
                break;
            case '*':
                resultado = Multiplicar(numero1, numero2);
                break;
            case '/':
                if (numero2 != 0)
                {
                    resultado = Dividir(numero1, numero2);
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    operacaoValida = false;
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
    static double Adicionar(double a, double b)
    {
        return a + b;
    }

    // Método para subtração
    static double Subtrair(double a, double b)
    {
        return a - b;
    }

    // Método para multiplicação
    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    // Método para divisão
    static double Dividir(double a, double b)
    {
        return a / b;
    }
}
