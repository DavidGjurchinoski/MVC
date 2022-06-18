namespace PizzApp.Models.ViewModels
{
    public class PizzaViewModel
    {
        public PizzaViewModel(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

    }
}
