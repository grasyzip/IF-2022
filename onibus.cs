using System;
using System.Linq;

public class Onibus
{

    int[] janela = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45 };
    int[] corredor = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46 };

    private int seleciona { get; set; }
    private int retira { get; set; }

    public Onibus() { }

    public Onibus(int poltrona, int assento)
    {
        this.seleciona = poltrona;
        this.retira = assento;

    }

    public Onibus(int poltrona, int assento, Data datacompar, Horario horacompar)
    {

        this.seleciona = poltrona;
        this.retira = assento;

    }

    public void retiraassento()
    {

        if (this.retira % 2 == 0 && this.seleciona == 2 && this.retira <= 46)
        {

            corredor = corredor.Where(e => e != this.retira).ToArray();
            Console.WriteLine(String.Join(" | ", corredor));

        }
        else if (this.retira % 2 != 0 && this.seleciona == 1 && this.retira <= 46)
        {

            janela = janela.Where(e => e != this.retira).ToArray();

            Console.WriteLine(String.Join(" | ", janela));

        }

    }
}