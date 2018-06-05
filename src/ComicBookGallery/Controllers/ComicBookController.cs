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
            
            
            //prepare data to be passed to the Detail view
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueTitle = 700;
            ViewBag.Description = "<p>Final issue</>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            //switch to the Detail view
            return View();

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