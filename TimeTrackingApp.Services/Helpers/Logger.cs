using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackingApp.Services.Helpers
{
    public class Logger
    {
        public static void Log(string error)
        {
            var msg = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} - {error}";
            File.AppendAllLines("log.txt", new List<string> { msg });
        }
    }
}
