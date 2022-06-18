using Microsoft.AspNetCore.Mvc;
using PizzApp.Database;
using PizzApp.Models.Entities;

namespace PizzApp.Controllers
{
    [Route("home")]
    public class PizzaController : Controller
    {
        [Route("pizzas")]
        public IActionResult Index()
        {
            return View(PizzaDatabase.Pizzas);
        }

        [Route("details")]
        public IActionResult Details(int Id)
        {
            Pizza pizza = PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == Id);

            if (pizza is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(pizza);
        }
    }
}
