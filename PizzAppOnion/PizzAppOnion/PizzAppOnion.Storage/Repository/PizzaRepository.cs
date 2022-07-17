using PizzApp.Services.Mappers;
using PizzAppOnion.Contracts.ViewModels.Pizza;
using PizzAppOnion.Domain.Enteties;
using PizzAppOnion.Domain.Repositories;
using PizzAppOnion.Storage.Database;

namespace PizzAppOnion.Storage.Repository
{
    internal class PizzaRepository : IPizzaRepository
    {
        public void Delete(int id)
        {
            PizzaDatabase.PIZZAS.Remove(PizzaDatabase.PIZZAS.FirstOrDefault(p => p.Id == id));
        }

        public IReadOnlyList<PizzaViewModel> GetAllPizzas()
        {
            return PizzaDatabase.PIZZAS.Select(x => x.ToPizzaViewModel()).ToList();
        }

        public Pizza GetPizza(int id)
        {
            return PizzaDatabase.PIZZAS.FirstOrDefault(p => p.Id == id);
        }

        public void Insert(Pizza createPizza)
        {
            PizzaDatabase.PIZZAS.Add(createPizza);
        }

        public void Update(Pizza updatedPizza)
        {
            PizzaDatabase.PIZZAS[updatedPizza.Id] = updatedPizza;
        }
    }
}
