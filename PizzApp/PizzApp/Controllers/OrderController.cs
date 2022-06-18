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
            return View(OrderDatabase.Orders);
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
