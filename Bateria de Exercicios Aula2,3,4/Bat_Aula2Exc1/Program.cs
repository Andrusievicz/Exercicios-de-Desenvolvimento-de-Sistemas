using System;

class Program
{
    static void Main()
    {
        // Declaração de variáveis de diferentes tipos de dados
        int numeroInteiro = 42;
        double numeroDouble = 3.141591;
        float numeroFloat = 2.780f;
        bool numeroBool = false;
        char caractere = 'A';
        string texto = "oie";
        decimal numeroDecimal = 2.21435121985129032m;
        long numeroLong = 123123L;
        byte numeroByte = 255;

        // Exibe os valores das variáveis na tela
        Console.WriteLine("Os valores das variaveis são:");
        Console.WriteLine($"int: {numeroInteiro}");
        Console.WriteLine($"double: {numeroDouble}");
        Console.WriteLine($"float: {numeroFloat}");
        Console.WriteLine($"bool: {numeroBool}");
        Console.WriteLine($"char: {caractere}");
        Console.WriteLine($"string: {texto}");
        Console.WriteLine($"decimal: {numeroDecimal}");
        Console.WriteLine($"long: {numeroLong}");
        Console.WriteLine($"byte: {numeroByte}");
    }
}