using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nypf.Data;

namespace Nypf.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Data()
        {
            using (var db = new DataContext())
            {
                db.Artist.Add(new Artist {LastName = "Beck", FirstName ="John"});
                db.SaveChanges();
                var artists = db.Artist.ToList();
                return View(artists);
            }
        }
    }
}
