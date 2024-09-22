using System;

class Carro
{
    // Campos privados
    private string Marca;
    private int Ano;

    // Construtor que inicializa os campos Marca e Ano
    public Carro(string marca, int ano)
    {
        this.Marca = marca;
        this.Ano = ano;
    }

    // Construtor de cópia
    public Carro(Carro outroCarro)
    {
        this.Marca = outroCarro.Marca;
        this.Ano = outroCarro.Ano;
    }

    // Destruidor que exibe uma mensagem quando o objeto é destruído
    ~Carro()
    {
        Console.WriteLine($"O carro da {Marca}, ano {Ano}, foi destruído.");
    }

    // Método que exibe as informações do carro
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"\nAno: {Ano}\n");
    }
}

class Program
{
    static void Main()
    {
        // Inicializa um objeto da classe Carro
        Carro meuCarro = new Carro("Corolla", 2020);

        // Usa o construtor de cópia para criar um novo objeto Carro
        Carro carroCopia = new Carro("Fastback", 2025);

        // Exibe as propriedades Marca e Ano do carro original
        Console.Write("Informações do carro original: ");
        meuCarro.ExibirInformacoes();

        // Exibe as propriedades Marca e Ano do carro copiado
        Console.Write("Informações do carro copiado: ");
        carroCopia.ExibirInformacoes();

        // Força a coleta de lixo para ver o destruidor em ação
        meuCarro = null;
        carroCopia = null;

        // Força a execução do garbage collector
        GC.Collect();
        GC.WaitForPendingFinalizers();

        // Pausa para garantir que as mensagens de destruição sejam exibidas antes do final do programa
        Console.WriteLine("\nFinal do programa.");
    }
}