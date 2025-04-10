using AirCompany.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Models
{
    public class Crew:BaseModel
    {
        public string Name { get; set; }
        public Role Role { get; set; }
        public ICollection<Airplane> Airplanes { get; set; }= new List<Airplane>();
    }
}
