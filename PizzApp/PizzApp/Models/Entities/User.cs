namespace PizzApp.Models.Entities
{
    public class User
    {
        public User(int id, string name, List<string> addresses)
        {
            Id = id;
            Name = name;
            Addresses = addresses;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Addresses { get; set; }

    }
}
