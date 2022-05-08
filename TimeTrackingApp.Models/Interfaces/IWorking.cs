using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Models.Enums;

namespace TimeTrackingApp.Models.Interfaces
{
    public interface IWorking
    {
        public WorkingPlace PlaceOfWork { get; set; }
    }
}
