namespace PizzAppOnion.Domain.Enteties
{
    public class Pizza
    {
        public Pizza(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool IsOnPromotion { get; set; }
    }
}
