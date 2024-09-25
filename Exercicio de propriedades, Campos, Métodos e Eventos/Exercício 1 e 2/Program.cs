using System;

class Pessoa
{
    // Campos privados
    private string nome;
    private int idade;

    // Propriedade pública para acessar e modificar o campo nome
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    // Propriedade pública para acessar e modificar o campo idade
    public int Idade
    {
        get { return idade; }

        set
        {
            if (value >= 0) // Verificação para garantir que a idade não seja negativa
                idade = value;
            else
                Console.WriteLine("A idade não pode ser negativa.");
        }
    }

    // Construtor que inicializa os campos nome e idade
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método para exibir as informações da pessoa
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}.");
        Console.WriteLine($"Idade: {Idade} anos.");
    }

    // Método que aumenta a idade da pessoa em 1
    public void Aniversario()
    {
        Idade++;
        Console.WriteLine("\nParabéns! Você fez aniversário.");
    }
}

class Program
{
    static void Main()
    {
        // Inicializa um objeto da classe Pessoa
        Pessoa pessoa = new Pessoa("João", 30);

        // Exibe as informações iniciais da pessoa
        Console.WriteLine("\nInformações iniciais:\n");
        // Exibe as informações da pessoa
        pessoa.ExibirInformacoes();

        // Chama o método Aniversario para aumentar a idade
        pessoa.Aniversario();

        // Exibe as informações atualizadas da pessoa
        Console.WriteLine("\nInformações após o aniversário:\n");
        pessoa.ExibirInformacoes();

        Console.ReadKey();
    }
}
