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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                
                // Start by instantiating the array
                Artists = new Artist[]
                { 
                    // Then add an artist model instance with name + role properties
                    new Artist() {Name = "Dan Slott", Role = "Script"},
                    new Artist() {Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() {Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() {Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() {Name = "Chris Eliopoulos", Role = "Letters"},
                }
            };
            // Pass our comic books instances to our view
            return View(comicBook);   
        }
    }
}