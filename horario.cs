using System;

public class Horario
{

    public int Hora { get; set; }
    public int Minuto { get; set; }
    //public int horaH { get; set; }

    public Horario(int hora, int minuto)
    {
        if(Hora > 24 || Hora < 00 && Minuto > 59 || Minuto < 00){
          hora = 00;
          minuto = 00;
        }
        else{
          sethora(Hora);
          setminuto(Minuto);
          
        }
    }

    public int comparaHora(Horario horacompar)
    {
        if (
            horacompar.gethora() == this.Hora &&
            horacompar.getminuto() == this.Minuto )
        {
            return 0;
        }
        else if (
            //horacompar.gethora > this.Hora &&
          horacompar.Hora > this.Hora &&
            horacompar.getminuto() >= this.Minuto)
        {
            return 1;
        }
        else
        {
            return -1;
        }

    }
  
    public void sethora(int valor)
    {
        this.Hora = valor;
    }

    public int gethora()
    {
        return Hora;
    }

    public void setminuto(int valor)
    {
        this.Minuto = valor;
    }

    public int getminuto()
    {
        return Minuto;
    }
}