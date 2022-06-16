namespace PizzApp.Models.Entities
{
    public class Pizza
    {
        public Pizza(int id, string name, int price)
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
