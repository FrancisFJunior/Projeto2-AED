using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Cliente cliente = new Cliente();   
    Loja loja = new Loja();
    Carrinho car = new Carrinho();
    string SouN = "S";
    loja.NomeLj();
    cliente.CadastroCliente();
    

    while (SouN == "S"){
      loja.Produtos();
      Console.Write("Deseja continuar a compra? (S / N) ");
      SouN = Console.ReadLine();
      Console.Clear();
    } 
    car.MostraCar();


    do{
      Console.WriteLine("Deseja retirar algum item?(S / N) ");
      SouN = Console.ReadLine();
      if(SouN == "S"){
        Console.WriteLine("Digite o numero do item a ser removido: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade a ser removida: ");
        int qntI = int.Parse(Console.ReadLine());
        car.Remover(i,qntI);
      }
    }while (SouN == "S");
  }
}