using PizzApp.Models.Entities;

namespace PizzApp.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public User User { get; set; }

        public string OrderAddress { get; set; }

        public int TotalPrice { get; set; }

        public List<PizzaViewModel> Pizzas { get; set; }
    }
}
