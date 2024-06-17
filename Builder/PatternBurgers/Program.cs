namespace PatternBurgers;

class Program
{
    static void Main(string[] args)
    {
        // Criar o Atendente (Client)
        Atendente atendente = new Atendente();

        var pedidoAtendente = atendente.AnotarPedido("Batata Média","Hambúrguer",   "Coca","Carrinho");

        // Criar o Builder
        IPedidoBuilder pedidoBuilder = new PedidoBuilder();

        // Criar o Funcionário (Director)
        Funcionario funcionario = new Funcionario(pedidoBuilder);

        // Solicitar montagem do pedido
        funcionario.MontarPedido(pedidoAtendente);

        // Obter o pedido
        Pedido pedido = funcionario.GetPedido();

        // Imprimir o pedido
        atendente.ImprimirPedido(pedido);
    }
}