using System;

// Exceção personalizada para idade inválida
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {

    }
}

class Program
{
    // Função que verifica se a idade está dentro de um intervalo válido
    static void VerificarIdade(int idade)
    {
        if (idade < 0 || idade > 120)
        {
            // Lança a exceção personalizada se a idade estiver fora do intervalo
            throw new InvalidAgeException($"Idade inválida: {idade}. A idade deve estar entre 0 e 120.");
        }
        else
        {
            Console.WriteLine($"Idade válida: {idade}");
        }
    }

    static void Main()
    {
        try
        {
            // Solicita que o usuário insira uma idade
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            // Chama a função para verificar a idade
            VerificarIdade(idade);
        }
        catch (InvalidAgeException ex)
        {
            // Captura e trata a exceção personalizada
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (FormatException ex)
        {
            // Captura e trata entradas inválidas
            Console.WriteLine("Erro: Entrada inválida. Por favor, digite um número inteiro");
        }
        catch (Exception ex)
        {
            // Captura qualquer outra exceção não tratada
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}