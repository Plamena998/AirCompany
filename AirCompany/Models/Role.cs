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
    public class Role: BaseModel
    {
        [MaxLength(20)]
        public string RoleName { get; set; }
        public ICollection<Crew> Crews { get; set; }
    }
}
