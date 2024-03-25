using System;

public class Pedido
{
    public string Item { get; set; }
    public double Total { get; set; }

    public void AddItem(Prodto item, int qtd)
    {
        this.Total += item.Preco * qtd;
    }

    public void Pagr(Pagamento pagamento)
    {
        if (pagamento.Valr >= this.Total)
        {
            Console.WriteLine("Pagamento sucedido!");
        }
        else
        {
            Console.WriteLine("Valor insuficiente.");
        }
    }
}