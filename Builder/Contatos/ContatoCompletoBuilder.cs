namespace Contatos;

public class ContatoCompletoBuilder : IContatoBuilder {
    private Contato _contato = new();

    public void ConstruirContato(string nome, string endereco, string telefone, string email)
    {
        _contato.Nome = nome;
        _contato.Endereco = endereco;
        _contato.Telefone = telefone;
        _contato.Email = email;
    }

    public Contato GetContato() {
        return _contato;
    }
}