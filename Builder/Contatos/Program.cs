namespace Contatos;

class Program
{
    static void Main(string[] args)
    {
        string nome = "João Silva";
        string endereco = "Rua Principal, 123";
        string telefone = "987654321";
        string email = "joao@example.com";

        // Criar builders
        IContatoBuilder internetBuilder = new ContatoInternetBuilder();
        IContatoBuilder telefoneBuilder = new ContatoTelefoneBuilder();
        IContatoBuilder completoBuilder = new ContatoCompletoBuilder();

        // Criar e usar o diretor
        Director director;

        // Criar contato Internet
        director = new Director(internetBuilder);
        director.ConstruirContato(nome, endereco, telefone, email);
        Contato contatoInternet = director.GetContato();
        Console.WriteLine(contatoInternet.ToString());

        // Criar contato Telefone
        director = new Director(telefoneBuilder);
        director.ConstruirContato(nome, endereco, telefone, email);
        Contato contatoTelefone = director.GetContato();
        Console.WriteLine(contatoTelefone.ToString());

        // Criar contato Completo
        director = new Director(completoBuilder);
        director.ConstruirContato(nome, endereco, telefone, email);
        Contato contatoCompleto = director.GetContato();
        Console.WriteLine(contatoCompleto.ToString());
    }
}