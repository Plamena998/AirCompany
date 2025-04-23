using AirCompany.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Models
{
    public class Payroll : BaseModel
    {
        //public int PassengerId { get; set; }
        //public Passenger Passenger { get; set; } = null!;
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public decimal Total { get; set; }
    }
}