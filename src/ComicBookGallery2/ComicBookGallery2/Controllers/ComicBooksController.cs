using ComicBookGallery2.Data;
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
        private ComicBookRepository _comicBookRepository = null;

        // Add constructor 
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        
        // Writing ? after int will enable to accept a nullable type
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // When using a nullable type, need to use 
            // either a value property   (id.Value)
            // or an explicit cast ((Int)id)
            var comicBook = _comicBookRepository.GetComickBook(id.Value);
            
            return View(comicBook);   
        }
    }
}
