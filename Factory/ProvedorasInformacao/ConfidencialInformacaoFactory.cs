namespace ProvedorasInformacao;

public class ConfidencialInformacaoFactory : InformacaoFactory {
    public override IInformacao CriarInformacao() {
        return new ConfidencialInformacao();
    }
}