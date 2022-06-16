using PizzApp.Models.Entities;

namespace PizzApp.Database
{
    public static class PizzaDatabase
    {
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza(1, "Pizza1", 400),
            new Pizza(2, "Pizza2", 4050),
            new Pizza(3, "Pizza3", 2300),
            new Pizza(4, "Pizza4", 600),
        };
    }
}
