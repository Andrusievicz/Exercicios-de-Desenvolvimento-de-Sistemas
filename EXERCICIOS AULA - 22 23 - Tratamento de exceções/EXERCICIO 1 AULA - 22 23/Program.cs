using System;

class Program
{
    static void Main()
    {
        try
        {
            // Solicita que o usuário digite um número inteiro
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            // Realiza a divisão de 100 pelo número fornecido
            int resultado = 100 / numero;

            // Exibe o resultado
            Console.WriteLine($"100 Dividido por {numero} é {resultado}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erro: Não é possivel dividir por zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Entrada inválida. Por favor digite um número inteiro.");
        }
        catch (Exception ex)
        {
            // Trata qualquer outra exceção que não tenha sido capturada
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}