/*
Implementação do padrão de projeto Factory Method no contexto de logística, com modalidades de logística aérea e terrestre. Ambas as modalidades herdam da classe base Logistica, que define os métodos CriarTransporte e ExecutarEntrega. Este exemplo demonstra como é possível criar diferentes formas de entrega, garantindo que o sistema seja extensível e flexível para futuras mudanças. O uso do Factory Method permite que novas modalidades de transporte possam ser adicionadas sem alterar o núcleo do sistema, promovendo uma maior escalabilidade e manutenção do código.
*/


using System;
class Program
{
    public static void Main(string[] args)
    {
        new Cliente().Main();
    }
}
class Cliente
{
    public void Main()
    {
        Console.WriteLine("Inicialização");
        ClienteCode(new LogisticaTerrestre());
        Console.WriteLine("");
        Console.WriteLine("Criando entrega Aeria");
        ClienteCode(new LogisticaAeria());
    }
    public void ClienteCode(Logistica logistica)
    {
        Console.WriteLine("O Cliente receberar a entrega " + logistica.executarEntrega());
    }
}