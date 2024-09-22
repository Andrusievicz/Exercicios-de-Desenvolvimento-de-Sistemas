using System;

// Declaração da interface IVeiculo
interface IVeiculo
{
    void Ligar();
    void Desligar();
}

// Implementação da classe Carro que implementa a interface IVeiculo
class Carro : IVeiculo
{
    public void Ligar()
    {
        Console.WriteLine("O carro está ligado.");
    }

    public void Desligar()
    {
        Console.WriteLine("O carro está desligado.");
    }
}

// Implementação da classe Moto que implementa a interface IVeiculo
class Moto : IVeiculo
{
    public void Ligar()
    {
        Console.WriteLine("A moto está ligada.");
    }

    public void Desligar()
    {
        Console.WriteLine("A moto está desligada.");
    }
}

class Program
{
    static void Main()
    {
        // Criação de objetos das classes Carro e Moto
        IVeiculo meuCarro = new Carro();
        IVeiculo minhaMoto = new Moto();

        // Usando os métodos Ligar e Desligar de cada classe
        meuCarro.Ligar();
        meuCarro.Desligar();

        minhaMoto.Ligar();
        minhaMoto.Desligar();
    }
}