namespace UTFPRDesignPatterns;

public class FilePrinter : IPrinter {
    public void Print(string message) {
        System.IO.File.WriteAllText("output.txt", message);
    }
}