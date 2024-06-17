namespace UTFPRDesignPatterns;

public class ConsolePrintFactory : IPrintFactory
{
    public IPrinter CreatePrinter()
    {
        return new ConsolePrinter();
    }
}