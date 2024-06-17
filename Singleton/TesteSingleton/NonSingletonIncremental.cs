namespace TesteSingleton;

public class NonSingletonIncremental
{
    private static int count = 0;
    private int numero;

    public NonSingletonIncremental() {
        numero = ++count;
    }

    public override string ToString() {
        return "Incremental " + numero;
    }
}

public class SingletonIncremental {
    private static SingletonIncremental instance;
    private static int count = 0;
    private int numero;

    private SingletonIncremental() {
        numero = ++count;
    }

    public static SingletonIncremental GetInstance() {
        if (instance == null) {
            instance = new SingletonIncremental();
        }
        return instance;
    }

    public override string ToString() {
        return "Incremental " + numero;
    }
}