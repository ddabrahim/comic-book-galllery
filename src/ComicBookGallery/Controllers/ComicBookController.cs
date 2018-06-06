using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail() //actionresult is the base result type used by both RedirectResult and ContentResult
        {

            //instantiate the comicbook model
            var comicBook = new ComicBook()
            {
                //prepare data to be passed to the Detail view
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue</>",
                Artists = new Artist[]
                {
                    new Artist() {Name= "Dan Sloww", Role="Script" },
                    new Artist() {Name= "Humberto Ramos", Role="Pencils" },
                    new Artist() {Name= "Victor Olazaba", Role="Inks" },
                    new Artist() {Name= "Edgar Delgado", Role="Colors" },
                    new Artist() {Name= "Chris Eliopoulos", Role="Letters" },
                }
            };

            //switch to the Detail view nad pass the comicBook model to the view
            return View(comicBook);

            /*//if the day is tuesday, redirect to an other page
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                // return new RedirectResult("/"); As our class inherit from the Controller class, we can simplyify this using the Redirect method
                return Redirect("/");
            }
            */


            //return Content("Hello");
            /* As our class inherit from the Controller class, we can simplify this using the Content method
            return new ContentResult()
            {
                Content = "Hello"
            };
            */
        }
    }
}