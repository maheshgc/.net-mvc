using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISMT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ISMT.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Details()
        {
            List<BookModel> book = new List<BookModel>()
            { new BookModel() {
                BookId = 123,
                BookName = "SDLC",
                BookAuthor = "Sandip Sir",
                },
                new BookModel() {
                BookId = 123,
                BookName = "SDLC",
                BookAuthor = "Sandip Sir",
                }
            };

            return View(book);
        }

        
    }
}