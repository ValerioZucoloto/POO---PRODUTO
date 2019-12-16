class Produto{

  private int _data_validade;
  private int _lote;
  private string _descricao;
  private int _peso;
  private int _preco;

  // public Produto () {
  //   Console.WriteLine ("Não há informações do produto !");
  // }

  public Produto (int datavalidade, int lote, string descricao, int peso, int preco ) {
    
    _data_validade = datavalidade;
    _lote = lote;
    _descricao = descricao;
    _peso = peso;
    _preco = preco;
  }


  public int Getdatavalidade ()
  {
    return _data_validade;
  }

  public int Getlote ()
  {
    return _lote;
  }

  public string Getdescricao ()
  {
    return _descricao;
  }

  public int Getpeso ()
  {
    return _peso;
  }

  public int Getpreco ()
  {
    return _preco;
  }

  public void Setdata_validade (int datavalidade)
  {
    _data_validade = datavalidade;
  }

  public void Setlote (int lote)
  {
    _lote = lote;
  }

  public void Setdescricao (string descricao)
  {
    _descricao = descricao;
  }

  public void Setpeso (int peso)
  {
    _peso = peso;
  }

  public void Setpreco (int preco)
  {
    _preco = preco;
  }

public override string ToString(){
  return "Validade: " + _data_validade + " Lote: " + _lote + " Descrição: " + _descricao + " Peso: " + _peso + " Preço: " + _preco;
}

}