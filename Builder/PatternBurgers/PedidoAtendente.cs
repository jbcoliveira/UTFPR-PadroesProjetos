namespace PatternBurgers;

public class PedidoAtendente
{
    public string Sanduiche { get; set; }
    public string Batata { get; set; }
    public string Brinquedo { get; set; }
    public string Refrigerante { get; set; }

    public PedidoAtendente(string sanduiche, string batata, string brinquedo, string refrigerante)
    {
        Brinquedo = brinquedo;
        Batata = batata;
        Sanduiche = sanduiche;
        Refrigerante = refrigerante;
    }
}