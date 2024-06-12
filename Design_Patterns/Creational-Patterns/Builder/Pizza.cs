namespace Design_Patterns.Creational_Patterns.Builder
{
    // Product class - Represents the complex object (Pizza)
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }

        public Pizza(string dough, string sauce, List<string> toppings)
        {
            Dough = dough;
            Sauce = sauce;
            Toppings = toppings;
        }
    }

    // Builder Interface - Defines methods for creating parts of the Pizza
    public interface IPizzaBuilder
    {
        IPizzaBuilder SetDough(string dough);
        IPizzaBuilder SetSauce(string sauce);
        IPizzaBuilder AddTopping(string topping);
        Pizza Build();
    }

    // Concrete Builder Class - Implements the builder interface and assembles the Pizza
    public class PizzaBuilder : IPizzaBuilder
    {
        private string _dough;
        private string _sauce;
        private List<string> _toppings = new List<string>();

        public IPizzaBuilder SetDough(string dough)
        {
            _dough = dough;
            return this;
        }

        public IPizzaBuilder SetSauce(string sauce)
        {
            _sauce = sauce;
            return this;
        }

        public IPizzaBuilder AddTopping(string topping)
        {
            _toppings.Add(topping);
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(_dough, _sauce, _toppings);
        }
    }

    //// Usage Example
    //public static void Main(string[] args)
    //{
    //    IPizzaBuilder hawaiianPizzaBuilder = new PizzaBuilder();
    //    Pizza hawaiianPizza = hawaiianPizzaBuilder
    //        .SetDough("Thin Crust")
    //        .SetSauce("Tomato")
    //        .AddTopping("Ham")
    //        .AddTopping("Pineapple")
    //        .Build();

    //    IPizzaBuilder veggiePizzaBuilder = new PizzaBuilder();
    //    Pizza veggiePizza = veggiePizzaBuilder
    //        .SetDough("Thick Crust")
    //        .SetSauce("Pesto")
    //        .AddTopping("Mushrooms")
    //        .AddTopping("Onions")
    //        .AddTopping("Bell Peppers")
    //        .Build();

    //    // Now you have hawaiianPizza and veggiePizza objects with their specific configurations
    //}
}
