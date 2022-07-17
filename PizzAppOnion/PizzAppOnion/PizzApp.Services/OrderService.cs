using PizzApp.Services.Mappers;
using PizzAppOnion.Contracts.Services;
using PizzAppOnion.Contracts.ViewModels.Order;
using PizzAppOnion.Domain.Enteties;
using PizzAppOnion.Domain.Repositories;

namespace PizzApp.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IReadOnlyList<OrderViewModel> GetAllOrders()
        {
            IReadOnlyList<Order> dbOrders = _orderRepository.GetAllOrders();

            return dbOrders.Select(x => x.ToOrderViewModel()).ToList();
        }

        public OrderViewModel GetOrder(int id)
        {
            return _orderRepository.GetOrder(id).ToOrderViewModel();
        }
    }
}
