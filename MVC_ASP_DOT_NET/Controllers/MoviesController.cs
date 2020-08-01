using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ASP_DOT_NET.Models;

namespace MVC_ASP_DOT_NET.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random => http://localhost:19811/movies/random
        // Using this way it is good practice to use below for unit test
        //public ViewResult Random()
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            return View(movie);


            //Alternatevily we can return this way ActionResult:

            //return new ViewResult();
            //return Content("Hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //will redirect you to homepage and query strings are added http://localhost:19811/?page=1&sortBy=name
            //return RedirectToAction("Index", "Home", new { page=1, sortBy="name" });
        }
        // GET: http://localhost:19811/movies/edit/1 || http://localhost:19811/movies/edit?id=1 => id=1
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // GET: http://localhost:19811/movies => pageIndex=1&sortBy=Name || http://localhost:19811/movies?pageIndex=2&sortBy=moon => pageIndex=2&sortBy=moon
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        // Details are in RouteConfig.cs
        // GET: movies/released/{year}/{month}" => http://localhost:19811/movies/released/2015/january => 2015/january
        //public ActionResult ByReleaseDate(int year, string month) => 2015/January
        public ActionResult ByReleaseDate(int year, int month)// 2015/4
        {
            
            return Content(year + "/" + month);
        }
    }
}