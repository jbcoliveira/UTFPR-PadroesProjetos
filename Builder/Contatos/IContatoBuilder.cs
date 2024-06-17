namespace Contatos;

public interface IContatoBuilder {

    void ConstruirContato(string nome, string endereco, string telefone, string email);
    Contato GetContato();
}