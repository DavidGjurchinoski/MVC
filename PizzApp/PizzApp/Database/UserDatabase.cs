using PizzApp.Models.Entities;

namespace PizzApp.Database
{
    public static class UserDatabase
    {
        public static List<User> Users = new List<User>()
        {
            new User(1, "User1", new List<string>(){"Adress1 User1", "Adress2 User1", "Adress3 User1"}),
            new User(2, "User2", new List<string>(){"Adress1 User2", "Adress2 User2", "Adress3 User2"}),
            new User(3, "User3", new List<string>(){"Adress1 User3"}),
            new User(4, "User4", new List<string>(){"Adress1 User4"}),
        };
    }
}
