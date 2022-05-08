using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Models.Enums;

namespace TimeTrackingApp.Services.Helpers
{
    public static class Helper
    {
        public static string GetInput(string type)
        {
            Console.Write(type);
            string input = Console.ReadLine();
            return input;
        }

        public static void ShowError(string ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex);
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void ShowSuccesMsg(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
            Thread.Sleep(1500);
        }

        public static int ParseInput(string str)
        {
            bool isValid = int.TryParse(str, out int number);

            if (!isValid)
            {
                throw new ApplicationException("Invalid number");
            }
            else
            {
                return number;
            }
        }

        public static int GetType<T>()
        {
            int counter = 1;
            foreach (var name in Enum.GetNames(typeof(T)))
            {
                Console.WriteLine($"{counter}. {name}");
                counter++;
            }

            string selection = Console.ReadLine();

            int parsedSelection = ParseInput(selection);

            var type = Enum.GetName(typeof(T), parsedSelection);

            if (type == null)
            {
                throw new ApplicationException("Invalid selection");
            }
            else
            {
                return parsedSelection;
            }
        }
    }
}