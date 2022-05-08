using TimeTrackingApp.Models.Classes;

namespace TimeTrackingApp.Models.Interfaces
{
    public interface IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
