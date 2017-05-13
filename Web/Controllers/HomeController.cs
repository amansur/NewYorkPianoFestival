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
        public HomeController(NypfContext db)
        {
            _db = db;
        }

        private NypfContext _db { get; set; }

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
            _db.Artist.Add(new Artist {LastName = "Beck", FirstName ="John"});
            _db.SaveChanges();
            var artists = _db.Artist.ToList();
            return View(artists);
        }
    }
}
