using PizzAppOnion.Contracts.ViewModels.Pizza;
using PizzAppOnion.Domain.Enteties;

namespace PizzAppOnion.Domain.Repositories
{
    public interface IPizzaRepository
    {
        IReadOnlyList<PizzaViewModel> GetAllPizzas();

        Pizza GetPizza(int id);

        void Insert(Pizza createPizza);

        void Update(Pizza existingPizza);

        void Delete(int id);
    }
}
