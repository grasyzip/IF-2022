using System;

    public class Prodto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quanti { get; set; }

  
    public Prodto(string nome, double preco, int quanti)
    {
        Nome = nome;
        Preco = preco;
        Quanti = quanti;
    }
}