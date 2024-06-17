namespace Contatos;

public class Director
{
    private IContatoBuilder _builder;


    public Director(IContatoBuilder builder) {
        _builder = builder;
    }

    public void ConstruirContato(string nome, string endereco, string telefone, string email) {
        _builder.ConstruirContato(nome, endereco, telefone, email);
    }

    public Contato GetContato() {
        return _builder.GetContato();
    }
}