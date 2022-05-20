using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Models.Classes;
using TimeTrackingApp.Services.Menus;

namespace TimeTrackingApp.Services.UserServices
{
    public class AccountService
    {
        public void AccountManagerMenu(User user)
        {
            while (true)
            {
                try
                {
                    Screen.AccountServiceMenu(user.FirstName);
                }
                catch (Exception)
                {

                    throw;
                }
            } 
        }
    }
}
