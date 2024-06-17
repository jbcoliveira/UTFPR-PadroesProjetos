namespace Nomes;

public class Nome
{
    public string PrimeiroNome { get; }
    public string Sobrenome { get; }

    public Nome(string primeiroNome, string sobrenome) {
        PrimeiroNome = primeiroNome;
        Sobrenome = sobrenome;
    }

    public override string ToString() {
        return $"{PrimeiroNome} {Sobrenome}";
    }
}