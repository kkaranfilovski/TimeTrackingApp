using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackingApp.Services.Helpers
{
    public static class Validation
    {
        public static string ValidateUsername()
        {
            while (true)
            {
                try
                {
                    string username = Helper.GetInput("Enter username: ");

                    if (username.Length < 5)
                    {
                        throw new ApplicationException("Username cannot be shorter then 5 characters");
                    }
                    else
                    {
                        return username;
                    }
                }
                catch (ApplicationException ex)
                {
                    Helper.ShowError(ex.Message);
                    Logger.Log(ex.Message);
                }
            }
        }

        public static string ValidatePassoword()
        {
            while (true)
            {
                try
                {
                    string password = Helper.GetInput("Enter password: ");

                    if (password.Length < 6)
                    {
                        throw new ApplicationException("Password cannot be shorter then 6 characters");
                    }
                    else if (!password.Any(x => char.IsDigit(x)))
                    {
                        throw new ApplicationException("Password must contain at least one number");
                    }
                    else if (!password.Any(x => char.IsUpper(x)))
                    {
                        throw new ApplicationException("Password must contain at least one capital letter");
                    }
                    else
                    {
                        return password;
                    }
                }
                catch (ApplicationException ex)
                {
                    Helper.ShowError(ex.Message);
                    Logger.Log(ex.Message);
                }
            }
        }

        public static string ValidateName(string firstOrLast)
        {
            while (true)
            {
                try
                {
                    string name = Helper.GetInput($"Enter your {firstOrLast}: ");
                    if (name.Length < 2)
                    {
                        throw new ApplicationException("Name cannot be shorter then 2 characters");
                    }
                    else if (name.Any(x => char.IsDigit(x)))
                    {
                        throw new ApplicationException("Name cannot contain number");
                    }
                    else
                    {
                        return name;
                    }
                }
                catch (ApplicationException ex)
                {
                    Helper.ShowError(ex.Message);
                    Logger.Log(ex.Message);
                }
            }
        }

        public static int ValidateAge()
        {
            while (true)
            {
                try
                {
                    string input = Helper.GetInput("Enter your age: ");
                    int age = Helper.ParseInput(input);

                    if (age < 18 || age > 120)
                    {
                        throw new ApplicationException("Age must be between 18 and 120");
                    }
                    else
                    {
                        return age;
                    }
                }
                catch (ApplicationException ex)
                {
                    Helper.ShowError(ex.Message);
                    Logger.Log(ex.Message);
                }
            }
        }
    }
}
