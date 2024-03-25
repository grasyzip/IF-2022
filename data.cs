using System;

public class Data
{

    public int dia { get; set; }
    public int mes { get; set; }
    public int ano { get; set; }

    public Data(int Dia, int Mes, int Ano)
    {
        if(Dia > 31 || Dia < 00 && Mes > 12 || Mes < 1){
          dia = 01;
          mes = 01;
          ano = 0001;
        }
        else{
          setDia(dia);
          setMes(mes);
          setAno(ano); 
        }
    }

    public bool isBissexto()
    {
        return ano % 4 == 0;
    }

    public int comparaDatas(Data datacompar)
    {
        if (
            datacompar.getDia() == this.dia &&
            datacompar.getMes() == this.mes &&
            datacompar.getAno() == this.ano
            )
        {
            return 0;
        }
        else if (
            datacompar.getDia() > this.dia &&
            datacompar.getMes() >= this.mes &&
            datacompar.getAno() >= this.ano
        )
        {
            return 1;
        }
        else
        {
            return -1;
        }

    }

    public string getMesExtenso()
    {
        switch (mes)
        {
            case 1:
                return "Janeiro";
            case 2:
                return "Fevereiro";
            case 3:
                return "Março";
            case 4:
                return "Abril";
            case 5:
                return "Maio";
            case 6:
                return "Junho";
            case 7:
                return "Julho";
            case 8:
                return "Agosto";
            case 9:
                return "Setembro";
            case 10:
                return "Outubro";
            case 11:
                return "Novembro";
            default:
                return "Dezembro";
        }
    }
  
    public void setDia(int valor)
    {
        this.dia = valor;
    }

    public int getDia()
    {
        return dia;
    }

    public void setMes(int valor)
    {
        this.mes = valor;
    }

    public int getMes()
    {
        return mes;
    }

    public void setAno(int valor)
    {
        this.ano = valor;
    }

    public int getAno()
    {
        return ano;
    }
}