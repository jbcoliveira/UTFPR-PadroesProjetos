namespace FerramentaLog;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1) {
            Console.WriteLine("Por favor, forneça 'arquivo' ou 'console' como parâmetro.");
            return;
        }

        string parametro = args[0];
        LoggerFactory factory;

        // Seleciona a fábrica apropriada baseada no parâmetro fornecido.
        if (parametro.ToLower() == "arquivo") {
            factory = new FileLoggerFactory();
        } else if (parametro.ToLower() == "console") {
            factory = new ConsoleLoggerFactory();
        } else {
            Console.WriteLine("Parâmetro inválido. Use 'arquivo' ou 'console'.");
            return;
        }

        // Cria o logger e utiliza para contar até 10.
        ILogger logger = factory.CreateLogger();
        for (int i = 1; i <= 10; i++) {
            logger.Log($"Contagem: {i}");
        }
    }
}