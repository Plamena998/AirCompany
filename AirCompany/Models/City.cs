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
    public class City: BaseModel
    {
        [MaxLength(50)]
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Airport> Airports { get; set; } = new List<Airport>();
    }
}
