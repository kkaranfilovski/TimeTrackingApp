using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Models.Enums;

namespace TimeTrackingApp.Models.Interfaces
{
    public interface IReading
    {
        public int NumOfPages { get; set; }
        public int ReadPages { get; set; }
        public ReadingTypes Type { get; set; }
    }
}
