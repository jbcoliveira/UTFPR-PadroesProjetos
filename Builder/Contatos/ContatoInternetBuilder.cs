namespace Contatos;

public class ContatoInternetBuilder : IContatoBuilder {
    private Contato _contato = new ();

    public void ConstruirContato(string nome, string endereco, string telefone, string email)
    {
        _contato.Nome = nome;
        _contato.Email = email;
    }

    public Contato GetContato() {
        return _contato;
    }

    public void ImprimirContato()
    {
        throw new NotImplementedException();
    }
}