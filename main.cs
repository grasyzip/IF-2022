using System;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine ("Você deseja sentar em qual lado?");
    Console.WriteLine("1 - Janela");
    Console.WriteLine("2 - Corredor");

    string Respost = Console.ReadLine();
switch ( Respost)
{
  case "1":
    Onibus Lugar1 = new Onibus(1, 25);
    Lugar1.retiraassento();  
      

    break;
      
  case "2":
    Onibus Lugar2 = new Onibus(2, 24);
    Lugar2.retiraassento();

    break;
   
  }
}
}