using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Models.Classes;

namespace TimeTrackingApp.Data
{
    public static class InMemoryDatabase
    {
        private static List<User> Users { get; set; }

        static InMemoryDatabase()
        {
            InitDatabase();
        }

        private static void InitDatabase()
        {
            Users = new List<User>()
            {
                new User("Kristijan", "Karanfilovski", 26, "kiko1", "Kiko123"),
                new User("Ilija", "Mitev", 26, "ilija1", "Ilija123"),
                new User("Petko", "Petkovski", 29, "petko1", "Petko123")
            };
        }

        public static User GetUserByUsername(string username)
        {
            return Users.FirstOrDefault(x => x.Username == username);
        }

        public static List<User> GetAllUsers()
        {
            return Users;
        }
    }
}
