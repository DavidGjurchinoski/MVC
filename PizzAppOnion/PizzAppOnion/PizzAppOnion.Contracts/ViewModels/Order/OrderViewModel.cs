using PizzAppOnion.Contracts.ViewModels.Pizza;

namespace PizzAppOnion.Contracts.ViewModels.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public string UsersFullName { get; set; }

        public decimal TotalPrice { get; set; }

        public string Address { get; set; }

        public DateTime? OrderDate { get; set; }

        public List<PizzaViewModel> Pizzas { get; set; }
    }
}
