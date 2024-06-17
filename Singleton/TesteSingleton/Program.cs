namespace TesteSingleton;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Non Singleton Incremental");
        for (int i = 0; i < 10; i++) {
            NonSingletonIncremental inc = new NonSingletonIncremental();
            Console.WriteLine(inc);
        }

        Console.WriteLine("Singleton Incremental");
        for (int i = 0; i < 10; i++) {
            SingletonIncremental inc = SingletonIncremental.GetInstance();
            Console.WriteLine(inc);
        }
    }
}