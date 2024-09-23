using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Solicita ao usuário o caminho do arquivo
            Console.Write("Digite o caminho do arquivo de texto: ");
            string caminhoArquivo = Console.ReadLine();

            // Lê o conteúdo do arquivo
            string conteudo = File.ReadAllText(caminhoArquivo);

            // Exibe o conteúdo do arquivo
            Console.WriteLine("\nConteúdo do arquivo: ");
            Console.WriteLine(conteudo);
        }
        catch (FileNotFoundException)
        {
            // Captura e trata a exceção de arquivo não encontrado
            Console.WriteLine("Erro: O arquivo especificado não foi encontrado.");
        }
        catch (UnauthorizedAccessException)
        {
            // Captura e trata a exceção de acesso negado ao arquivo
            Console.WriteLine("Erro: Acesso negado ao arquivo. Verifique as permissões.");
        }
        catch (IOException ex)
        {
            // Captura e trata outras exceções relacionadas a entrada/saída
            Console.WriteLine($"Erro de entrada/saída {ex.Message}");
        }
        catch (Exception ex)
        {
            // Captura qualquer outra exceção não tratada
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}