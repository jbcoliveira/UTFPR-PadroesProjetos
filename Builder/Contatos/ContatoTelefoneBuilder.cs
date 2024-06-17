namespace Contatos;

public class ContatoTelefoneBuilder : IContatoBuilder {
    private Contato _contato = new();

    public void ConstruirContato(string nome, string endereco, string telefone, string email)
    {
        _contato.Nome = nome;
        _contato.Telefone = telefone;
    }

    public Contato GetContato() {
        return _contato;
    }
}