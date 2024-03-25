using System;

public class Data
{

    private int dia;
    private int mes;
    private int ano;

    public Data(int dia, int mes, int ano)
    {

        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }
    public void setDia(int dia)
    {
        this.dia = dia;
    }
    public int getDia()
    {
        return dia;
    }
    public void setMes(int mes)
    {
        this.mes = mes;
    }
    public int getMes()
    {
        return mes;
    }
    public void setAno(int ano)
    {
        this.ano = ano;
    }
    public int getAno()
    {
        return ano;
    }

    //setData só aceita uma data válida
    public void setData(int dia, int mes, int ano)
    {
        if (dia > 01 && dia <= 31)
        {
            this.dia = dia;
        }
        if(mes > 01 && mes <= 12)
        {
            this.mes = mes;
        }
        if (ano > 0 && ano <= 4000)
        {
            this.ano = ano;
        }
    }
  
    //DataValida que verifica se os parâmetros é igual a data válida
    public void DataValida(int dia, int mes, int ano)
    {

    bool result = false;
    if (ano >= 2022)
    {
        if ((dia >= 1) && (dia <= 31))
        {
            if ((mes >= 1) && (mes <= 12))
            {
                result = true;
            }
        }
    }

    }

// eBissexto que verifica se o ano é bissexto ou não (true ou false)
    public bool eBissexto(int ano)
    {
    if (ano % 4 == 0)
        return true;
    else
        return false;
    //return ano % 4 == 0;
    } 
}