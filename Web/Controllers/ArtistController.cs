using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nypf.Data;
using Microsoft.EntityFrameworkCore;

namespace Nypf.Web.Controllers
{
    public class ArtistController : Controller
    {
    	public ArtistController(NypfContext db) { _db = db; }

    	private NypfContext _db { get; set; }

    	public async Task<IActionResult> Index()
    	{
    		var artists = await _db.Artist.ToListAsync();
    		return View(artists);
    	}

    	// public IActionResult Index()
    	// {
    	// 	var artists = _db.Artist.ToList();
    	// 	return View(artists);
    	// }
    }
}