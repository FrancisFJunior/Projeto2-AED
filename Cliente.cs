using System;
using System.Collections.Generic;

class Cliente {
  public static List<string> nome = new List<string>{};
  private int idade;
  private int cartao;
  DateTime thisDay = DateTime.Today;


  public void CadastroCliente(){
    Console.Write("\n|             Cadastro Cliente             |\n");
    Console.Write("| Nome: ");
    nome.Add(Console.ReadLine());
    Console.Write("| Idade: ");
    idade =int.Parse(Console.ReadLine());
    Console.Write("| Cartão: ");
    cartao=int.Parse(Console.ReadLine());
    Console.Write("|             Cadastro Concluido            |\n");
    Console.Write("| Pressione ENTER para acessar nossos itens |");
    Console.ReadLine();
    Console.Clear();

  }

  public void DadosC(){
    Console.WriteLine("|Nome:{0,-40} |{1,10}|",nome[0],thisDay.ToString("d"));
  }
 
}