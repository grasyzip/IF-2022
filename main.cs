using System;

class Program
{
    public static void Main(string[] args)
    {
        Prodto prodto1 = new Prodto("Feijão", 17.80, 2);
        Prodto prodto2 = new Prodto("Arroz", 9.70, 3);


        Pedido pedido = new Pedido();
        pedido.AddItem(prodto1, 2);
        pedido.AddItem(prodto2, 3);

        Console.WriteLine("Total do pedido: " + pedido.Total);

        Dineiro dineiro = new Dineiro();
        dineiro.Valr = 60;
        Console.WriteLine("Pagamento em Dinheiro");

        pedido.Pagr(dineiro);

        Cheque cheque = new Cheque();
        cheque.Valr = 20;
        Console.WriteLine("Pagando com cheque");

        pedido.Pagr(cheque);

        Carto carto = new Carto();
        carto.Valr = 70;
        Console.WriteLine("Pagando com cartão");
      

        pedido.Pagr(carto);
    }
}