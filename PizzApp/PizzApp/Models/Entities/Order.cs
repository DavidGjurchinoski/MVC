using PizzApp.Database;

namespace PizzApp.Models.Entities
{
    public class Order
    {
        public Order(int id, int userId, string userAddress, List<Pizza> pizzas)
        {
            Id = id;
            UserId = userId;
            OrderAddress = userAddress;
            Pizzas = pizzas;
            TotalPrice = GetTotalPrice(pizzas);
            User = UserDatabase.Users.FirstOrDefault(x => x.Id == userId);
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public string OrderAddress { get; set; }

        public int TotalPrice { get; set; }

        public List<Pizza> Pizzas { get; set; }

        private int GetTotalPrice(List<Pizza> pizzas)
        {
            int totalPrice = 0;

            pizzas.ForEach(x => totalPrice += x.Price);

            return totalPrice;
        } 
    }
}
