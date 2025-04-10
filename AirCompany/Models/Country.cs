using AirCompany.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Models
{
    public class Country:BaseModel
    {
        [MaxLength(20)]
        public string CountryName { get; set; }
        public int ContinentId { get; set; }
        public Continent Continent { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
