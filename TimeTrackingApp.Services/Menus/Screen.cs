using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Models.Classes;

namespace TimeTrackingApp.Services.Menus
{
    public static class Screen
    {
        public static void WelcomeMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Time Tracking Application");
            Console.WriteLine();
            Console.WriteLine("Choose one of the following options:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
        }

        public static void MainMenu(string name)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the Main Menu {name}");
            Console.WriteLine();
            Console.WriteLine("Choose one of the following options:");
            Console.WriteLine("1. Track your activities");
            Console.WriteLine("2. Statistics");
            Console.WriteLine("3. Account management");
            Console.WriteLine("4. Log out");
        }

        public static void ActivityMenu()
        {
            Console.Clear();
            Console.WriteLine("Activities");
            Console.WriteLine();
            Console.WriteLine("Choose one of the following options:");
            Console.WriteLine("1. Reading");
            Console.WriteLine("2. Exercising");
            Console.WriteLine("3. Working");
            Console.WriteLine("4. Other hobbies");
            Console.WriteLine("5. Go back");
        }
    }
}
