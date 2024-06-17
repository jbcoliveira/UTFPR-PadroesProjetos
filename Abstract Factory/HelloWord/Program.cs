namespace UTFPRDesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        // Gerador de números aleatórios
        Random random = new Random();
        IPrintFactory printFactory;

        // Escolhe aleatoriamente a fábrica
        if (random.Next(2) == 0) {
            printFactory = new ConsolePrintFactory();
        } else {
            printFactory = new FilePrintFactory();
        }

        // Cria o printer e imprime a mensagem
        IPrinter printer = printFactory.CreatePrinter();
        printer.Print("Hello, World!");
    }
}