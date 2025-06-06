﻿using AirCompany.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany.Models
{
    public class FlightStatusChange:BaseModel
    {
        public DateTime ChangedAt { get; set; }
        public Flight Flight { get; set; }
        public Guid FlightId { get; set; }
        public FlightStatus FlightStatus { get; set; }
        public int FlightStatusId { get; set; }
    }
}
