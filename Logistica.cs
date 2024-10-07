using System;
public abstract class Logistica {

  public abstract ITransporte criarTransporte();

  public string executarEntrega(){
    var entrega = criarTransporte(); // criando o tramporte
    var result = $"{entrega.Entrega()}"; //realizando a entrega 
    return result;
  }
  
}