using System;

class MainClass {
  public static void Main (string[] args) {

    Produto P;

    Console.Write ("Insira a data de validade: ");
    int validade  = int.Parse (Console.ReadLine());
    

    Console.Write ("Insira o lote: ");
    int lote  = int.Parse (Console.ReadLine());
   
    Console.Write ("Insira a descrição: ");
    string descricao  = Console.ReadLine ();

    Console.Write ("Insira o peso: ");
    int peso  = int.Parse (Console.ReadLine());

    Console.Write ("Insira o preço: ");
    int preco  = int.Parse (Console.ReadLine());
    
    P = new Produto (validade, lote, descricao, peso, preco);

    Console.WriteLine (P);


  }
}