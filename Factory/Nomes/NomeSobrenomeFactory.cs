namespace Nomes;

public class NomeSobrenomeFactory : NomeFactory {
    public override Nome CriarNome(string nomeCompleto) {
        string[] partes = nomeCompleto.Split(' ');
        string primeiroNome = partes[0];
        string sobrenome = partes.Length > 1 ? partes[1] : string.Empty;
        return new Nome(primeiroNome, sobrenome);
    }
}