namespace PatternBurgers;

public class Funcionario
{
    private IPedidoBuilder _builder;

    public Funcionario(IPedidoBuilder builder) {
        this._builder = builder;
    }
    public void MontarPedido(PedidoAtendente pedidoAtendente) {
        _builder.AdicionarSanduiche(pedidoAtendente.Sanduiche);
        _builder.AdicionarBatata(pedidoAtendente.Batata);
        _builder.AdicionarBrinquedo(pedidoAtendente.Brinquedo);
        _builder.AdicionarRefrigerante(pedidoAtendente.Refrigerante);
    }
    
    public Pedido GetPedido() {
        return _builder.GetPedido();
    }
}