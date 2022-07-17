using PizzAppOnion.Contracts.ViewModels.Pizza;
using PizzAppOnion.Domain.Enteties;

namespace PizzApp.Services.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel ToPizzaViewModel(this Pizza pizza)
        {
            return new PizzaViewModel()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price
            };
        }
    }
}
