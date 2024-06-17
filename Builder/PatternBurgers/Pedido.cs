using System.Text;

namespace PatternBurgers;

public class Pedido
{
    private HashSet<string> _dentroDaCaixa = new HashSet<string>();
    private HashSet<string> _foraDaCaixa = new HashSet<string>();

    public void AdicionarDentroDaCaixa(string item) {
        _dentroDaCaixa.Add(item);
    }

    public void AdicionarForaDaCaixa(string item) {
        _foraDaCaixa.Add(item);
    }

    public override string ToString() {
        StringBuilder buffer = new StringBuilder();
        buffer.Append("Seu pedido:\n");
        buffer.Append("Dentro da caixa:\n");
        foreach (string item in _dentroDaCaixa) {
            buffer.Append("\t" + item + "\n");
        }
        buffer.Append("Fora da caixa:\n");
        foreach (string item in _foraDaCaixa) {
            buffer.Append("\t" + item + "\n");
        }
        buffer.Append("\nTenha um bom dia!\n\n");
        return buffer.ToString();
    }

}