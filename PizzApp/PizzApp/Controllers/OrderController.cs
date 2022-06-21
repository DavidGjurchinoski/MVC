using Microsoft.AspNetCore.Mvc;
using PizzApp.Database;
using PizzApp.Models.Mappers;
using PizzApp.Models.ViewModels;

namespace PizzApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            List<OrderViewModel> orders = OrderDatabase.Orders.Select(x => x.ToOrderViewModel()).ToList();

            return View(orders);
        }

        [Route("Details")]
        public IActionResult Details(int id)
        {
            OrderViewModel order = OrderDatabase.Orders.FirstOrDefault(x => x.Id == id).ToOrderViewModel();
      
            if(order is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(order);
        }
    }
}
