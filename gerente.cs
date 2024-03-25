using System; 
class Gerente:Funcionario {
  
  //atributos
  private int QtdFunc;
  
  //getters e setters
  public int getQtdFunc(){return this.QtdFunc;}
  public void setQtdFunc(int f){this.QtdFunc = f;}

  //construtor
  public Gerente(){ }
  public Gerente(string n,string c,double s,int qtd): base(n,c,s){
     this.setQtdFunc(qtd);
  }

  public void cancelarOperacao(){
    Console.WriteLine("Operação cancelada");
  }
}