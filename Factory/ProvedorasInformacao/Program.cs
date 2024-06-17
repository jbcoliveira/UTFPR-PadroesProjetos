namespace ProvedorasInformacao;

class Program
{
    static void Main(string[] args)
    {
        string senha = string.Empty;
        // Verifica se o usuário forneceu a senha.
        if (args.Length > 0) {
            senha = args[0];
        }

        InformacaoFactory factory;

        // Seleciona a fábrica apropriada baseada na senha fornecida.
        if (senha == "designpatterns") {
            factory = new ConfidencialInformacaoFactory();
        } else {
            factory = new PublicaInformacaoFactory();
        }

        // Cria o provedor de informação e obtém a informação.
        IInformacao informacao = factory.CriarInformacao();
        string conteudo = informacao.ObterInformacao();

        // Exibe a informação na tela.
        Console.WriteLine(conteudo);
    }
}