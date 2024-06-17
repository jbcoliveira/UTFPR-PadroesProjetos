namespace FerramentaLog;

public class FileLogger : ILogger {
    private readonly string filePath = "log.txt";

    public void Log(string message) {
        using (StreamWriter writer = File.AppendText(filePath)) {
            writer.WriteLine(message);
        }
    }
}