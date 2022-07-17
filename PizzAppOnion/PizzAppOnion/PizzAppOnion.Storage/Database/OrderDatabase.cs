using PizzAppOnion.Domain.Enteties;

namespace PizzAppOnion.Storage.Database
{
    public static class OrderDatabase
    {
        public static List<Order> ORDERS = new List<Order>()
        {
            new Order(GetNextId(), UserDatabase.USERS.FirstOrDefault(x => x.Id ==  1), "Address1", new List<Pizza>()
            {
                PizzaDatabase.PIZZAS.FirstOrDefault(x => x.Id == 1),
                PizzaDatabase.PIZZAS.FirstOrDefault(x => x.Id == 1),
                PizzaDatabase.PIZZAS.FirstOrDefault(x => x.Id == 4),
                PizzaDatabase.PIZZAS.FirstOrDefault(x => x.Id == 3),
                PizzaDatabase.PIZZAS.FirstOrDefault(x => x.Id == 2),
            }),
            new Order(GetNextId(), UserDatabase.USERS.FirstOrDefault(x => x.Id ==  2), "Address2", new List<Pizza>()
            {
                PizzaDatabase.PIZZAS.FirstOrDefault(x => x.Id == 1),
                PizzaDatabase.PIZZAS.FirstOrDefault(x => x.Id == 2),
                PizzaDatabase.PIZZAS.FirstOrDefault(x => x.Id == 2),
            }),
            new Order(GetNextId(), UserDatabase.USERS.FirstOrDefault(x => x.Id ==  1), "Address1", new List<Pizza>()
            {
                PizzaDatabase.PIZZAS.FirstOrDefault(x => x.Id == 1)
            }),
        };


        public static int GetNextId()
        {
            return (ORDERS.OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
        }
    }
}
