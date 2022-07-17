namespace PizzAppOnion.Domain.Enteties
{
    public class Order
    {
        public Order(int id, User user, string address, List<Pizza> pizzas)
        {
            Id = id;
            User = user;
            Address = address;
            Pizzas = pizzas;
            CreatedAt = DateTime.Now;
        }

        public int Id { get; set; }

        public User User { get; set; }

        public List<Pizza> Pizzas { get; set; }

        public string Address { get; set; }

        public DateTime? CreatedAt { get; set; }

        public decimal GetTotalPrice()
        {
            return Pizzas.Sum(x => x.Price);
        }

    }
}
