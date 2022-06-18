using PizzApp.Models.Entities;

namespace PizzApp.Database
{
    public static class OrderDatabase
    {
        public static List<Order> Orders = new List<Order>()
        {
            new Order(1, 1, "Adress1", new List<Pizza> ()
            {
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 1),
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 1),
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 3),
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 2),
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 2),
            }),
            new Order(2, 1, "Adress1", new List<Pizza> ()
            {
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 1),
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 3),
            }),
            new Order(3, 2, "Adress2", new List<Pizza> ()
            {
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 1),
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 1),
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 3),
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 2),
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 2),
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 4),
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 4),
            }),
            new Order(4, 3, "Adress3", new List<Pizza> ()
            {
                PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == 3)
            }),
        };
    }
}
