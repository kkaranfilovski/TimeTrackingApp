using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Models.Interfaces;

namespace TimeTrackingApp.Models.Classes
{
    public class User : IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Activity> Activities { get; set; }

        public User(string fName, string lName, int age, string username, string password)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            Username = username;
            Password = password;
            Activities = new List<Activity>();
        }
    }
}
