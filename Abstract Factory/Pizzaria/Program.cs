using System.Globalization;

namespace UTFPRPizzaria;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0) {
            Console.WriteLine("Por favor, forneça uma data no formato dd/mm/yyyy.");
            return;
        }

        DateTime date;
        try {
            date = DateTime.ParseExact(args[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);
        } catch (FormatException) {
            Console.WriteLine("Formato de data inválido. Use dd/mm/yyyy.");
            return;
        }

        var dayOfWeek = date.DayOfWeek;
        IPizzariaFactory pizzariaFactory;
        Console.WriteLine($"A data {date.ToString("d")} é {dayOfWeek.ToString()}");

        switch (dayOfWeek) {
            case DayOfWeek.Monday:
            case DayOfWeek.Wednesday:
            case DayOfWeek.Friday:
                pizzariaFactory = new CalabresaFactory();
                break;
            case DayOfWeek.Tuesday:
            case DayOfWeek.Thursday:
            case DayOfWeek.Saturday:
                pizzariaFactory = new PresuntoFactory();
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("A pizzaria está fechada aos domingos.");
                return;
            default:
                throw new ArgumentOutOfRangeException();
        }

        var client = new PizzariaClient(pizzariaFactory);
        client.ShowMenu();
    }


}