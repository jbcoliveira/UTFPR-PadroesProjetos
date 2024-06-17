namespace ProvedorasInformacao;

public class ConfidencialInformacao : IInformacao {
    private string _caminhoArquivo = "confidencial.txt";

    public string ObterInformacao() {
        return File.ReadAllText(_caminhoArquivo);
    }
}