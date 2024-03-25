using System;
class Funcionario{
   
   // atributos
    private string Nome;
    private string Cpf;
    private double Salario;
    private int Senha; 
   
   // getters e setters
    public string getNome(){return this.Nome;}
    public void setNome(string nome){this.Nome = nome;}

    public string getCpf(){return this.Cpf;}
    public void setCpf(string cpf){this.Cpf = cpf;}

    public double getSalario(){return this.Salario;}
    public void setSalario(double salario){this.Salario = salario;}

    public int getSenha(){return this.Senha;}
    public void setSenha(int senha){this.Senha = senha;}
   
   //construtores
    public Funcionario(){ }
    public Funcionario(string n,string c,double s){
      this.setNome(n);
      this.setCpf(c);
      this.setSalario(s);
      this.setSenha(1234);
    }
   
   //métodos
   public bool autentificar(int sen){
     if(sen == this.getSenha()) 
         return true;
     else 
       return false;
   }

   public void imprimeDados(){
     Console.WriteLine("-----------------------");
     Console.WriteLine("Nome: " + this.getNome());
     Console.WriteLine("Cpf: " + this.getCpf());
     Console.WriteLine("Salário: R$ " + this.getSalario());
     Console.WriteLine("Senha: " + this.getSenha());
     Console.WriteLine("-----------------------");
   }
   
   
 }