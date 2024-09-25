using System;

class Alarme
{
    // Declaração do evento AlarmeAtivado
    public event EventHandler AlarmeAtivado;

    // Método que ativa o alarme e dispara o evento
    public void AtivarAlarme()
    {
        Console.WriteLine("Alarme esta sendo ativado...");
        OnAlarmeAtivado();
    }

    // Método protegido para disparar o evento AlarmeAtivado
    protected virtual void OnAlarmeAtivado()
    {
        if (AlarmeAtivado != null)
        {
            AlarmeAtivado(this, EventArgs.Empty);
        }
    }
}

class Program
{
    static void Main()
    {
        // Cria uma instância da classe Alarme
        Alarme meuAlarme = new Alarme();

        // Assina um manipulador ao evento AlarmeAtivado
        meuAlarme.AlarmeAtivado += MeuAlarme_AlarmeAtivado;

        // Ativa o alarme
        meuAlarme.AtivarAlarme();
    }

    // Manipulador de eventos para o evento AlarmeAtivado
    private static void MeuAlarme_AlarmeAtivado(object sender, EventArgs e)
    {
        Console.WriteLine("O alarme foi ativado! Tome as medidas necessárias.");
    }
}