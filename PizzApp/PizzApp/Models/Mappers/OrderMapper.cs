using PizzApp.Models.Entities;
using PizzApp.Models.ViewModels;

namespace PizzApp.Models.Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToOrderViewModel(this Order order)
        {
            return new OrderViewModel() 
            {
                Id = order.Id,
                Pizzas = order.Pizzas,
                TotalPrice = order.TotalPrice,
                User = order.User  
            };
        }
    }
}
