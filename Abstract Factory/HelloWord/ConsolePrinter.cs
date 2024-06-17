namespace UTFPRDesignPatterns;

public class ConsolePrinter : IPrinter
{
    public void Print(string message) {
        Console.WriteLine(message);
    }
}