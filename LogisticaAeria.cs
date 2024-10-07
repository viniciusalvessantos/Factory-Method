public class LogisticaAeria : Logistica {
  public override ITransporte criarTransporte(){
    return new Aviao();
  }
}