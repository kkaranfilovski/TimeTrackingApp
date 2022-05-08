using System.Diagnostics;
using TimeTrackingApp.Models.Interfaces;

namespace TimeTrackingApp.Models.Classes
{
    public class Hobbies : Activity, ITrack, IHobbies
    {
        public Stopwatch TrackTime { get; set; }
        public string Name { get; set; }

        public Hobbies(string name)
        {
            Name = name;
            TrackTime = new Stopwatch();
        }
    }
}
