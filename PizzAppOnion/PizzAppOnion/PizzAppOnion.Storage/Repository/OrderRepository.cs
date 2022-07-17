using PizzAppOnion.Domain.Enteties;
using PizzAppOnion.Domain.Repositories;
using PizzAppOnion.Storage.Database;

namespace PizzAppOnion.Storage.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void Delete(int id)
        {
            OrderDatabase.ORDERS.Remove(OrderDatabase.ORDERS.FirstOrDefault(o => o.Id == id));
        }

        public IReadOnlyList<Order> GetAllOrders()
        {
            return OrderDatabase.ORDERS;
        }
    
        public Order GetOrder(int id)
        {
            return OrderDatabase.ORDERS.FirstOrDefault(o => o.Id == id);
        }

        public void Insert(Order createdOrder)
        {
            OrderDatabase.ORDERS.Add(createdOrder);
        }

        public void Update(Order updatedOrder)
        {
            OrderDatabase.ORDERS[updatedOrder.Id] = updatedOrder;
        }
    }
}
