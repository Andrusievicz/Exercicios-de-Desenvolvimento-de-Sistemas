using System;

// Declaração da interface IPessoa
interface IPessoa
{
    void Falar();
}

// Implementação da classe Aluno que implementa a interface IPessoa
class Aluno : IPessoa
{
    public void Falar()
    {
        Console.WriteLine("O Aluno está estudando.");
    }
}

// Implementação da classe Professor que implementa a interface IPessoa
class Professor : IPessoa
{
    public void Falar()
    {
        Console.WriteLine("O professor está ensinando.");
    }
}

class Program
{
    static void Main()
    {
        // Criação de objetos das classes Aluno e Professor
        IPessoa aluno = new Aluno();
        IPessoa professor = new Professor();

        // Chamando o método Falar em cada objeto
        aluno.Falar();
        professor.Falar();
    }
}