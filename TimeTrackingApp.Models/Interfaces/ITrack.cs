using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TimeTrackingApp.Models.Interfaces
{
    public interface ITrack
    {
        public Stopwatch TrackTime { get; set; }
    }
}
