using Microsoft.AspNetCore.Mvc;
using PizzApp.Database;
using PizzApp.Models.Mappers;
using PizzApp.Models.ViewModels;

namespace PizzApp.Controllers
{
    [Route("home")]
    public class PizzaController : Controller
    {
        [Route("pizzas")]
        public IActionResult Index()
        {
            List<PizzaViewModel> pizzas = PizzaDatabase.Pizzas.Select(x => x.ToPizzaListModel()).ToList();

            return View(pizzas);
        }

        [Route("details")]
        public IActionResult Details(int Id)
        {
            PizzaViewModel pizza = PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == Id).ToPizzaListModel();

            if (pizza is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(pizza);
        }
    }
}
