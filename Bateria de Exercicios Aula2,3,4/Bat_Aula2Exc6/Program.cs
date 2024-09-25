using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número correspondente ao dia da semana
        Console.Write("Digite um número de 1 a 7 correspondente ao dia da semana: ");
        
        int diadasemana = Convert.ToInt32(Console.ReadLine());

        // Verifica o valor da variável diadasemana e exibe o nome do dia correspondente
        switch (diadasemana)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda");
                break;
            case 3:
                Console.WriteLine("Terça");
                break;
            case 4:
                Console.WriteLine("Quarta");
                break;
            case 5:
                Console.WriteLine("Quinta");
                break;
            case 6:
                Console.WriteLine("Sexta");
                break;
            case 7:
                Console.WriteLine("Sabado");
                break;
            default:
                Console.WriteLine("Erro: número inválido. Digite um número de 1 a 7.");
                break;
        }

    }
}