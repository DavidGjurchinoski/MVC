using PizzAppOnion.Contracts.ViewModels.Order;
using PizzAppOnion.Domain.Enteties;

namespace PizzApp.Services.Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToOrderViewModel(this Order order)
        {
            return new OrderViewModel()
            {
                Id = order.Id,
                UsersFullName = order.User.Name + " " + order.User.LastName,
                Address = order.Address,
                TotalPrice = order.GetTotalPrice(),
                OrderDate = order.CreatedAt,
                Pizzas = order.Pizzas.Select(x => x.ToPizzaViewModel()).ToList()
            };
        }  
    }
}
