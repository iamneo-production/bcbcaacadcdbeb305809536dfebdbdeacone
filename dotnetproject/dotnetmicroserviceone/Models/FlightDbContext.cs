using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetmicroserviceone.Models
{
    public class FlightDbContext : DbContext
    {
        public DbSet<Flight> Flights { get; set;}
        public FlightDbContext(DbContextOption<FlightDbContext> options): base(options)
        {
            
        }
    }
}