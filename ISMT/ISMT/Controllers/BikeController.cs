using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISMT.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ISMT.Controllers
{
    public class BikeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            List<BikeModel> bike = new List<BikeModel>()
            {
                 new BikeModel() { BikeId=1, BikeName="pulsaar"},
                 new BikeModel() { BikeId=2, BikeName="apache"},
                 new BikeModel() { BikeId=3, BikeName="splender"}
            };

            return View(bike);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm]BikeModel input)
        {
            return View();
        }
    }
}
