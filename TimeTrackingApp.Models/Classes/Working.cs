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
    public class Working : Activity, ITrack, IWorking
    {
        public Stopwatch TrackTime { get; set; }
        public WorkingPlace PlaceOfWork { get; set; }

        public Working(WorkingPlace place)
        {
            PlaceOfWork = place;
            TrackTime = new Stopwatch();
        }
    }
}
