using AirCompany.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Models
{
    public class Flight:BaseModel
    {
        public int FlightDuration { get; set; }
        public DateTimeOffset FlightDate { get; set; }
        public ushort PassengersCount { get; set; }
        public ICollection<Crew> Crews { get; set; }
        public ICollection<FlightStatusChange> FlightStatusChanges { get; set; }
        public ICollection<Passenger> Passengers { get; set; }


    }
}
