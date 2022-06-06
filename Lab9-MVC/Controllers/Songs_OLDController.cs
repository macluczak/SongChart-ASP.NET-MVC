using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab9_MVC.Controllers
{
    public class Songs_OLDController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            Models.Song song = new Models.Song();
            song.Id = 1;
            song.Name = "Utwór 1";
            song.Artist = "Wykonawca 1";
            song.GenreId = 1;
            return View(song);
        }

        public ActionResult Square(int? id)
        {
            if (id == null)
            {
                return Content("Brak parametru");
            }
            else
            {
                return Content((id * id).ToString());
            }
        }
    }
}