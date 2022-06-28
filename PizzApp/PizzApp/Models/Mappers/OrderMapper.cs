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
                TotalPrice = order.GetTotalPrice(),
                User = order.User,
                OrderAddress = order.OrderAddress,
            };
        }
    }
}
