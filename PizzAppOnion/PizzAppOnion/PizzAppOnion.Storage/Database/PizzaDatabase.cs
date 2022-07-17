using PizzAppOnion.Domain.Enteties;

namespace PizzAppOnion.Storage.Database
{
    public static class PizzaDatabase
    {
        public static List<Pizza> PIZZAS = new List<Pizza>()
        {
            new Pizza(1, "Mozzarela", 9.99m),
            new Pizza(2, "Movi", 5.99m),
            new Pizza(3, "Kaprichioza", 10m),
            new Pizza(4, "Peperony", 3.99m),
            new Pizza(5, "Mozzarela", 1m),
            new Pizza(6, "Big Boy", 29.99m)
        };
    }
}
