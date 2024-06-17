namespace Nomes;

public class SobrenomeNomeFactory : NomeFactory {
    public override Nome CriarNome(string nomeCompleto) {
        string[] partes = nomeCompleto.Split(new[] { ", " }, StringSplitOptions.None);
        string sobrenome = partes[0];
        string primeiroNome = partes.Length > 1 ? partes[1] : string.Empty;
        return new Nome(primeiroNome, sobrenome);
    }
}