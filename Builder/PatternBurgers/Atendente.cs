namespace PatternBurgers;

public class Atendente
{

    //A ordem dos parâmetros foi propositalmente trocada para mostrar o uso de parâmetros nomeados
    public PedidoAtendente AnotarPedido( string batata,string sanduiche, string refrigerante, string brinquedo )
    {
        return new PedidoAtendente(sanduiche, batata, brinquedo, refrigerante);
    }

    public void ImprimirPedido(Pedido pedido)
    {
        Console.WriteLine(pedido.ToString());
    }

}