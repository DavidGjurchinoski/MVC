using PizzApp.Models.Entities;
using PizzApp.Models.ViewModels;

namespace PizzApp.Models.Mappers
{
    public static class PizzaMapper
    {
       public static PizzaViewModel ToPizzaListModel(this Pizza pizza)
        {
            return new PizzaViewModel(pizza.Id, pizza.Name, pizza.Price);
        }
    };
}
