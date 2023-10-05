using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetmicroserviceone.Models
{
    public class Flight
    {
        public int FlightID { get; set;}
        public string FlightName { get; set;}
        public decimal TicketPrice {get; set;}
        public int TotalSeats { get; set;}
        public string Airline { get; set;}
        public string Pilot { get; set;}
        public string Status { get; set;}
        public string Gate { get; set;}
        public string Terminal { get; set;}
        
    }
}