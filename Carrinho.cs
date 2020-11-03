using System;
using System.Collections.Generic;

class Carrinho {
  Loja loja =new Loja();
  Cliente dados = new Cliente();

  public static List<int> carrinho = new List<int>{};
  public static List<int> qntCar = new List<int>{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

   public void MostraCar(){
    int cont=0;
    carrinho.Sort();
    loja.NomeLj();
    Console.WriteLine("-----------------------------------------------------------");
    dados.DadosC();
    Console.WriteLine("-----------------------------------------------------------");
    double vlTotal=0;
    foreach(int test in carrinho){ 
      double vlCompr= qntCar[test]*loja.preco[test];  
      Console.WriteLine("|{0,2}| {1,-35}  |{2,3}|= {3, 9:c2}|",loja.idProd[test],loja.descricao[test],qntCar[test],vlCompr);
      cont++;
      vlTotal = vlTotal+vlCompr;

    }
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("|Valor Total {0, 45:c2}|",vlTotal);
    Console.WriteLine("-----------------------------------------------------------");

  }

  public void Remover(int i, int qntI){
    foreach(int test in carrinho){
      if(qntI > qntCar[test]){
      Console.WriteLine(">>QUANTIDADE MAIOR QUE A ARMAZENADA<<\n>>>PRESSIONE ENTER PARA VOLTAR AO CARRINHO<<<");
      Console.ReadLine();
      Console.Clear();
    }
    if(qntCar[test] >= qntI & qntI >= 0 & i == test){
      qntCar[test] = qntCar[test] - qntI;
      Console.Clear();
    }
    
    }
    MostraCar();
    
  }


}