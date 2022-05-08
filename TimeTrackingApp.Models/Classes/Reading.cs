using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Models.Enums;
using TimeTrackingApp.Models.Interfaces;

namespace TimeTrackingApp.Models.Classes
{
    public class Reading : Activity, ITrack, IReading
    {
        public Stopwatch TrackTime { get; set; }
        public ReadingTypes Type { get; set; }
        public int NumOfPages { get; set; }
        public int ReadPages { get; set; }

        public Reading(ReadingTypes type, int numOfPages)
        {
            TrackTime = new Stopwatch();
            Type = type;
            NumOfPages = numOfPages;
            ReadPages = 0;
        }
    }
}
