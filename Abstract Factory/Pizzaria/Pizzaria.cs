namespace UTFPRPizzaria;



    // Interface para os produtos Pizza e Calzone
    public interface IPizza {
        void GetIngredients();
    }

    public interface ICalzone {
        void GetIngredients();
    }

    // Implementação concreta dos produtos
    public class PizzaCalabresa : IPizza {
        public void GetIngredients() {
            Console.WriteLine("Pizza de Calabresa: Queijo, Calabresa, Tomate");
        }
    }

    public class PizzaPresunto : IPizza {
        public void GetIngredients() {
            Console.WriteLine("Pizza de Presunto: Queijo, Presunto, Tomate");
        }
    }

    public class CalzoneCalabresa : ICalzone {
        public void GetIngredients() {
            Console.WriteLine("Calzone de Calabresa: Queijo, Calabresa, Tomate");
        }
    }

    public class CalzonePresunto : ICalzone {
        public void GetIngredients() {
            Console.WriteLine("Calzone de Presunto: Queijo, Presunto, Tomate");
        }
    }

    // Interface para a Abstract Factory
    public interface IPizzariaFactory {
        IPizza CreatePizza();
        ICalzone CreateCalzone();
    }

    // Implementação concreta das fábricas
    public class CalabresaFactory : IPizzariaFactory {
        public IPizza CreatePizza() {
            return new PizzaCalabresa();
        }

        public ICalzone CreateCalzone() {
            return new CalzoneCalabresa();
        }
    }

    public class PresuntoFactory : IPizzariaFactory {
        public IPizza CreatePizza() {
            return new PizzaPresunto();
        }

        public ICalzone CreateCalzone() {
            return new CalzonePresunto();
        }
    }

    // Cliente
    public class PizzariaClient {
        private readonly IPizzariaFactory _pizzariaFactory;

        public PizzariaClient(IPizzariaFactory pizzariaFactory) {
            _pizzariaFactory = pizzariaFactory;
        }

        public void ShowMenu() {
            var pizza = _pizzariaFactory.CreatePizza();
            var calzone = _pizzariaFactory.CreateCalzone();
            pizza.GetIngredients();
            calzone.GetIngredients();
        }
    }