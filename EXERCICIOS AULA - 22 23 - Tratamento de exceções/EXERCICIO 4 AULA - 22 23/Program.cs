using System;

class Program
{
    // Função que lança uma exceção se o valor for inválido
    static void VerificarValor(int valor)
    {
        if (valor < 0)
        {
            throw new ArgumentException("O valor não pode ser negativo.");
        }
        else
        {
            Console.WriteLine($"Valor válido: {valor}");
        }
    }

    // Método que captura a exceção e relança para ser tratada em um nível superior
    static void MetodoIntermediario(int valor)
    {
        try
        {
            VerificarValor(valor);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro no método intermediário: " + ex.Message);
            throw; // Relança a exceção para ser tratada no nível superior
        }
    }

    static void Main()
    {
        try
        {
            // Solicita que o usuário insira um valor
            Console.Write("Digite um número inteiro: ");
            int valor = int.Parse(Console.ReadLine());

            // Chama o método intermediário que pode relançar a exceção
            MetodoIntermediario(valor);
        }
        catch (ArgumentException ex)
        {
            // Captura e trata a exceção relançada
            Console.WriteLine("Erro tratado no nível superior: " + ex.Message);
        }
        catch (FormatException)
        {
            // Captura e trata entradas inválidas (não numéricas)
            Console.WriteLine("Erro: Entrada inválida. Por favor, digite um número inteiro.");
        }
        catch (Exception ex)
        {
            // Captura qualquer outra exceção não tratada
            Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
        }
    }
}