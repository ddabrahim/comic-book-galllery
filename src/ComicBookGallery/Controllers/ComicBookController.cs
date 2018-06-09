using ComicBookGallery.Data;
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
        private ComicBookRepository _comicBookRepository = null;

        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? Id) //actionresult is the base result type used by both RedirectResult and ContentResult
        {

            if (Id == null)
            {
                return HttpNotFound();
            }

            //instantiate the comicbook model
            var comicBook = _comicBookRepository.GetComicBook((int)Id);

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