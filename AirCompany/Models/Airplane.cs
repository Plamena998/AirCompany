using AirCompany.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Models
{
    public class Airplane:BaseModel
    {
        [MaxLength(100)]
        public ushort SeatsCount { get; set; }

        public ICollection<Airport> Airports { get; set; }= new List<Airport>();

        public ICollection<Flight> Flights { get; set; } = new List<Flight>();

    }
}
