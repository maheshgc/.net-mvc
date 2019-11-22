using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISMT.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ISMT.Controllers
{
    public class FlightController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<FlightModel> flight = new List<FlightModel>
            {
                new FlightModel()
                {
                    FlightNo=1,
                    Destination="Pokhara"
                },
                new FlightModel()
                {
                    FlightNo=2,
                    Destination="Kathmandu"
                }
            };
            return View(flight);
        }
    }
}
