using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISMT.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ISMT.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<StudentModel> stdList = new List<StudentModel>
            {
                new StudentModel(){  StudentAddress = "naya gau",
                                     StudentId = 1,
                                     StudentName = "Ram"
                                   },
                new StudentModel(){  StudentAddress = "gau",
                                     StudentId = 231,
                                     StudentName = "Hari"
                                   },
                new StudentModel(){  StudentAddress = "purano gau",
                                     StudentId = 123,
                                     StudentName = "Sita"
                                   }
            };
            
            return View(stdList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm]StudentModel inputData)
        {
            if (ModelState.IsValid)
            {
                return View("Details", inputData);
            }
            return View(inputData);
        }
    }
}
