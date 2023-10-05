using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetmicroserviceone.Controllers
{
    [Route("[controller]")]
    public class FlightController : Controller
    {
        private readonly FlightDbContext _context;
        public FlightController(FlightDbContext context)
        {
           _context = context; 
        }
        private readonly ILogger<FlightController> _logger;

        public FlightController(ILogger<FlightController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlightController>>> GetAllFlights()
        {

        }

        [HttpGet("names")]
        public async Task<ActionResult<IEnumerable<string>>> GetAirportNames()
        {

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Airport>> GetAirportById(int id)
        {

        }
        [HttpPost]
        public async Task<ActionResult<Airport>> AddAirport(Airport airport)
        {

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAirport(int id)
        {

        }
    }
}