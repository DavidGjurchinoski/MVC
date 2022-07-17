using PizzAppOnion.Domain.Enteties;

namespace PizzAppOnion.Storage.Database
{
    public static class UserDatabase
    {
        public static List<User> USERS = new List<User>()
        {
            new User(GetNextId(), "user1", "userL1"),
            new User(GetNextId(), "user2", "userL2"),
            new User(GetNextId(), "user3", "userL3"),
            new User(GetNextId(), "user4", "userL4"),
            new User(GetNextId(), "user5", "userL5"),
        };

        public static int GetNextId()
        {
            return (USERS.OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
        }
    }
}
