using PizzAppOnion.Contracts.Services;
using PizzAppOnion.Contracts.ViewModels.Pizza;
using PizzAppOnion.Domain.Repositories;

namespace PizzApp.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;

        public PizzaService(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public IReadOnlyList<PizzaViewModel> GetAllPizzas()
        {
           List<PizzaViewModel> pizzas = _pizzaRepository.GetAllPizzas().ToList();
        
           return pizzas;
        }
    }
}
