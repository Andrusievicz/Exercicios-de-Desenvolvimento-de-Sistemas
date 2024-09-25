using System;

public class ContaBancaria
{
    // Propriedade auto-implementada para o saldo
    public decimal Saldo { get; private set; }

    // Evento disparado quando o saldo é alterado
    public event EventHandler SaldoAlterado;

    // Método para adicionar valor ao saldo
    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de depósito inválido!");
            return;
        }

        Saldo += valor;
        OnSaldoAlterado(); // Dispara o evento
    }

    // Método para retirar valor do saldo
    public void Sacar(decimal valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente!");
            return;
        }

        Saldo -= valor;
        OnSaldoAlterado(); // Dispara o evento
    }

    // Método que dispara o evento SaldoAlterado
    protected virtual void OnSaldoAlterado()
    {
        SaldoAlterado?.Invoke(this, EventArgs.Empty); // Se houver inscritos, dispara o evento
    }
}

// Classe para manipular o evento SaldoAlterado
public class Banco
{
    public void ExibirMensagemSaldoAlterado(object sender, EventArgs e)
    {
        var conta = (ContaBancaria)sender;
        Console.WriteLine($"O saldo foi alterado. Saldo atual: {conta.Saldo:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();
        Banco banco = new Banco();

        // Assinando o evento SaldoAlterado
        conta.SaldoAlterado += banco.ExibirMensagemSaldoAlterado;

        // Modificando o saldo da conta
        conta.Depositar(100.00m);
        conta.Sacar(50.00m);
        conta.Sacar(60.00m); // Saldo insuficiente

        // Fim do programa
        Console.ReadKey();
    }
}
