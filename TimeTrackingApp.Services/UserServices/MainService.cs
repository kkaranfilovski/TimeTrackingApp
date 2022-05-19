using TimeTrackingApp.Data;
using TimeTrackingApp.Models.Classes;
using TimeTrackingApp.Services.Helpers;
using TimeTrackingApp.Services.Menus;

namespace TimeTrackingApp.Services.UserServices
{
    public class MainService
    {
        private readonly UserService userService = new UserService();

        public void Start()
        {
            while (true)
            {
                Screen.WelcomeMenu();
                string selection = Console.ReadLine();

                if (selection == "1")
                {
                    var LoggedUser = Login();
                    userService.UserMenu(LoggedUser);
                }
                else if (selection == "2")
                {
                    Register();
                    continue;
                }
                else if (selection == "3")
                {
                    InMemoryDatabase.SaveToDatabase();
                    Helper.ShowSuccesMsg("Thanks for using the app. See you again!");
                    break;
                }
                else
                {
                    Helper.ShowError("invalid selection");
                }
            }
        }

        private User Login()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    string username = Helper.GetInput("Enter your username: ");
                    string password = Helper.GetInput("Enter your password: ");
                    var user = InMemoryDatabase.GetUserByUsername(username);

                    if (user == null)
                    {
                        throw new ApplicationException("The username you entered doesn't belong to an account. Please check your username and try again.");
                    }
                    else
                    {
                        if (user.Password == password)
                        {
                            Helper.ShowSuccesMsg("Succesfull login");
                            return user;
                        }
                        else
                        {
                            throw new ApplicationException("Sorry, your password was incorrect. Please double-check your password.");
                        }
                    }
                }
                catch (ApplicationException ex)
                {
                    Helper.ShowError(ex.Message);
                    Logger.Log(ex.Message);
                }
            }
        }

        private void Register()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Register Menu");
            Console.WriteLine();

            string fName = Validation.ValidateName("firstname");
            string lName = Validation.ValidateName("lastname");
            int age = Validation.ValidateAge();
            string username = Validation.ValidateUsername();
            string password = Validation.ValidatePassoword();

            var user = new User(fName, lName, age, username, password);
            var users = InMemoryDatabase.GetAllUsers();

            users.Add(user);
            Helper.ShowSuccesMsg("Succesfull registrtaion. You can now login with your username and password");
        }
    }
}
