using AirCompany.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Models
{
    public class Passenger:BaseModel
    {
        [MaxLength(150)]
        public string Name { get; set; }
        public int TicketId { get; set; }

        public static void BuyingTickets()
        {
            
        }
    }
}
