namespace ProvedorasInformacao;

public class PublicaInformacaoFactory : InformacaoFactory {
    public override IInformacao CriarInformacao() {
        return new PublicaInformacao();
    }
}