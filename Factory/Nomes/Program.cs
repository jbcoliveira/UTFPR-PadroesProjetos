namespace Nomes;

class Program
{
    static void Main(string[] args)
    {
        // Entrada: Simulando a entrada de nomes.
        string[] entrada = { "Oliveira, João", "Roberto Carlos", "da Silva, José" };

        // Listas para armazenar os nomes criados.
        List<Nome> nomes = new List<Nome>();

        // Factories
        NomeFactory nomeSobrenomeFactory = new NomeSobrenomeFactory();
        NomeFactory sobrenomeNomeFactory = new SobrenomeNomeFactory();

        // Processar a entrada
        foreach (var nomeCompleto in entrada) {
            Nome nome;
            if (nomeCompleto.Contains(", ")) {
                nome = sobrenomeNomeFactory.CriarNome(nomeCompleto);
            } else {
                nome = nomeSobrenomeFactory.CriarNome(nomeCompleto);
            }
            nomes.Add(nome);
        }

        // Imprimir os resultados
        foreach (var nome in nomes) {
            Console.WriteLine(nome.ToString());
        }
    }
}