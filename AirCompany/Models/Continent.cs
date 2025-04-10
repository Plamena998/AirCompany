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
    public class Continent:BaseModel
    {
        [MaxLength(20)]
        public string ContinentName { get; set; }
        public ICollection<Country> Countries { get; set; }=new List<Country>();
    }
}
