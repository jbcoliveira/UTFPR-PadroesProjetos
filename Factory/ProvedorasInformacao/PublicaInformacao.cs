namespace ProvedorasInformacao;

public class PublicaInformacao : IInformacao {
    private string _caminhoArquivo = "publico.txt";

    public string ObterInformacao() {
        return File.ReadAllText(_caminhoArquivo);
    }
}