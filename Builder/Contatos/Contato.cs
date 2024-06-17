using System.Text;

namespace Contatos;

public class Contato
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public override string ToString() {
        var builder = new StringBuilder();
        builder.AppendLine("Contato:");
        builder.AppendLine($"Nome: {Nome}");
        if (!string.IsNullOrEmpty(Endereco)) builder.AppendLine($"Endereço: {Endereco}");
        if (!string.IsNullOrEmpty(Telefone)) builder.AppendLine($"Telefone: {Telefone}");
        if (!string.IsNullOrEmpty(Email)) builder.AppendLine($"Email: {Email}");
        return builder.ToString();
    }
}