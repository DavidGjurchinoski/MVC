using Microsoft.AspNetCore.Mvc;
using PizzApp.Database;
using PizzApp.Models.Entities;

namespace PizzApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View(OrderDatabase.Orders);
        }

        [Route("Details")]
        public IActionResult Details(int id)
        {
            Order order = OrderDatabase.Orders.FirstOrDefault(x => x.Id == id);
      
            if(order is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(order);
        }
    }
}
