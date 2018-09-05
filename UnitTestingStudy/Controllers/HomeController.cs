using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTestingStudy.Models;

namespace UnitTestingStudy.Controllers
{
    public class HomeController : Controller
    {
        ChinookEntities db = new ChinookEntities();


        [HttpPost]
        public ActionResult Index(int DropDown)
        {
            var x = db.Album.Where(s => s.ArtistId == DropDown);
            return View(x);
        }

        [HttpGet]
        public ActionResult Index()
        {


            var z = db.Album.ToList();
            var a = db.Artist.ToList();
            var zs = new SelectList(db.Album, "AlbumId", "Title");
            var artistList = new SelectList(db.Artist, "ArtistId", "Name");
            ViewBag.Test = artistList;



            return View(z);
        }


    }
}