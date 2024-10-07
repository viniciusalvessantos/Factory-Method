public class LogisticaTerrestre : Logistica
{
  public override ITransporte criarTransporte(){
    return new Caminhao();
  }
}