using AirCompany.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Models
{
    public class FlightStatus : BaseModel
    {
        [MaxLength(20)]
        public string Status { get; set; } = null!;
        public ICollection<FlightStatusChange> FlightStatusChanges { get; set; }
        

    }
}
