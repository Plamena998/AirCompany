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
    public class Ticket:BaseModel
    {
        //[Precision()]
        public int Id { get; set; }
        //public decimal TicketPrice { get; set; }

        public string Type { get; set; }
        public ushort SeatNumber { get; set; }
        public bool PaymentSuccess { get; set; }
        public int? PayrollId { get; set; }
        public Payroll Payroll { get; set; }
        public int FlightId { get; set; }
        public int UserId { get; set; }
        public Passenger User { get; set; } = null!;
        public Flight Flight { get; set; } = null!;
    }
}
