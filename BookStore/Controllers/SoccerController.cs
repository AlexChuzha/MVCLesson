using System.Linq;
using System;
using System.IO;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;
using BookStore.Util;
using System.Data.Entity;

namespace BookStore.Controllers
{
    public class SoccerController : Controller
    {  
        SoccerContext db = new SoccerContext();

        // Выводим всех футболистов
        public ActionResult Index()
        {
            //var players = db.Players.Include(p => p.Team);
            return View(db.Players.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}