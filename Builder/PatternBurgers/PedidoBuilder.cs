namespace PatternBurgers;

public interface IPedidoBuilder {
    void AdicionarSanduiche(string sanduiche);
    void AdicionarBatata(string batata);
    void AdicionarBrinquedo(string brinquedo);
    void AdicionarRefrigerante(string refrigerante);
    Pedido GetPedido();
}

public class PedidoBuilder : IPedidoBuilder {
    private Pedido _pedido = new();

    public void AdicionarSanduiche(string sanduiche) {
        _pedido.AdicionarDentroDaCaixa(sanduiche);
    }

    public void AdicionarBatata(string batata) {
        _pedido.AdicionarDentroDaCaixa(batata);
    }

    public void AdicionarBrinquedo(string brinquedo) {
        _pedido.AdicionarDentroDaCaixa(brinquedo);
    }

    public void AdicionarRefrigerante(string refrigerante) {
        _pedido.AdicionarForaDaCaixa(refrigerante);
    }

    public Pedido GetPedido() {
        return _pedido;
    }
}