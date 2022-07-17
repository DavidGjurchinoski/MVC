using Microsoft.AspNetCore.Mvc;
using PizzAppOnion.Contracts.Services;
using PizzAppOnion.Contracts.ViewModels.Order;

namespace PizzAppOnion.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            IEnumerable<OrderViewModel> ordersList = _orderService.GetAllOrders();

            return View(ordersList);
        }

        public IActionResult Details(int id)
        {
            OrderViewModel order = _orderService.GetOrder(id);

            return View(order);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
