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
    public class Exercising : Activity, ITrack, IExercising
    {
        public Stopwatch TrackTime { get; set; }
        public ExerciseTypes Type { get; set; }

        public Exercising(ExerciseTypes type)
        {
            Type = type;
            TrackTime = new Stopwatch();
        }
    }
}
