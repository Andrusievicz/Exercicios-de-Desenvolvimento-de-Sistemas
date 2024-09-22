using System;

// Declaração da classe abstrata Forma
abstract class Forma
{
    // Método abstrato CalcularArea
    public abstract double CalcularArea();
}

// Implementação da classe Retangulo que herda de Forma
class Retangulo : Forma
{
    // Propriedades para Largura e Altura
    public double Largura { get; set; }
    public double Altura { get; set; }

    // Construtor para inicializar Largura e Altura
    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    // Implementação do método CalcularArea
    public override double CalcularArea()
    {
        return Largura * Altura;
    }
}

// Implementação da classe Circulo que herda de Forma
class Circulo : Forma
{
    // Propriedade para o Raio
    public double Raio { get; set; }

    // Construtor para inicializar o Raio
    public Circulo(double raio)
    {
        Raio = raio;
    }

    // Implementação do método CalcularArea
    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}

class Program
{
    static void Main()
    {
        // Criação de objetos das classes Retangulo e Circulo
        Forma retangulo = new Retangulo(5.0, 3.0);
        Forma circulo = new Circulo(2.0);

        // Cálculo e exibição das áreas
        Console.WriteLine($"Área do Retângulo: {retangulo.CalcularArea()}");
        Console.WriteLine($"Área do Círculo: {circulo.CalcularArea()}");

    }
}