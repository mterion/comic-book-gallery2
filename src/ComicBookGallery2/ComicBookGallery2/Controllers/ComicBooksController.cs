using ComicBookGallery2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery2.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            // Pass our comic books instances to our view
            return View();   
        }
    }
}
