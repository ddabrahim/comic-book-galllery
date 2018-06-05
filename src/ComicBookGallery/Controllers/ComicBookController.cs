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
            //if the day is tuesday, redirect to an other page
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                // return new RedirectResult("/"); As our class inherit from the Controller class, we can simplyify this using the Redirect method
                return Redirect("/");
            }


            //return detail page
            return Content("Hello");

            /* As our class inherit from the Controller class, we can simplify this using the Content method
            return new ContentResult()
            {
                Content = "Hello"
            };
            */
        }
    }
}