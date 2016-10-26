using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Areas.Store.Controllers
{
    public class HomeController : Controller
    {
        // GET: Store/Home
        public string Index()
        {
            string text = "Store home controller";
            return text;
        }
    }
}