using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Produto
{
    public string Nome { get; set; }
    public string Categoria { get; set; }
}

class Program
{
    static void Main()
    {
        // Cria uma lista de objetos representando produtos
        List<Produto> produtos = new List<Produto>()
        {
            new Produto { Nome = "Banana", Categoria = "Fruta"},
            new Produto { Nome = "Maçã", Categoria = "Fruta"},
            new Produto { Nome = "Alface", Categoria = "Verdura"},
            new Produto { Nome = "Tomate", Categoria = "Verdura"},
            new Produto { Nome = "Arroz", Categoria = "Cereal"},
            new Produto { Nome = "Feijão", Categoria = "Cereal"}
        };

        // Usa LINQ para agrupar os produtos por categoria e contar quantos produtos existem em cada categoria
        var produtosPorCategoria = produtos
                                   .GroupBy(produto => produto.Categoria) // Agrupa por categoria
                                   .Select(grupo => new
                                   {
                                       Categoria = grupo.Key,
                                       Contagem = grupo.Count() // Conta quantos produtos existem em cada categoria   
                                   });

        // Imprime os resultados
        Console.WriteLine("Produtos agrupados por categoria:");
        foreach (var grupo in produtosPorCategoria)
        {
            Console.WriteLine($"Categoria: {grupo.Categoria}, Quantidade: {grupo.Contagem}");
        }
    }
}