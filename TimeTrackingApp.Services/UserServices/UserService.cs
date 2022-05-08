using TimeTrackingApp.Models.Classes;
using TimeTrackingApp.Services.Helpers;
using TimeTrackingApp.Services.Menus;

namespace TimeTrackingApp.Services.UserServices
{
    public class UserService
    {
        private TrackService trackService = new TrackService();
        private StatsService statsService = new StatsService();
        private AccountService accountService = new AccountService();

        public void UserMenu(User user)
        {
            while (true)
            {
                Screen.MainMenu(user.FirstName);
                string selection = Console.ReadLine();

                if(selection == "1")
                {
                    trackService.TrackActivityMenu(user);
                    continue;
                }
                else if(selection == "2")
                {
                    statsService.ShowStatsMenu(user);
                    continue;
                }
                else if(selection == "3")
                {
                    accountService.AccountManagerMenu(user);
                    continue;
                }
                else if(selection == "4")
                {
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Helper.ShowError("invalid selection");
                }
            }
        }
    }
}
