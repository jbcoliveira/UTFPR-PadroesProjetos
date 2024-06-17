namespace UTFPRDesignPatterns;

public class FilePrintFactory : IPrintFactory {
    public IPrinter CreatePrinter() {
        return new FilePrinter();
    }
}