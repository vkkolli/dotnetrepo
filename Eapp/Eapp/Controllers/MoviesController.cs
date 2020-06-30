using Eapp.Models;
using Eapp.ViewModels;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eapp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        //[Authorize]
        [OutputCache(Duration = 10)]
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Baahubali" };
            var customers = new List<Customer> { 
                new Customer { ID = 1,Name = "Vijay"}, 
                new Customer { ID =2 , Name = "Kumar"} };
            var viewModel = new RamdomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            List<string> Movies = new List<string>();
            Movies.Add("Darling");
            Movies.Add("Mirchi");
            Movies.Add("Chatrapathi");
            Movies.Add("Munna");
            ViewData["Movies"] = Movies;
            ViewBag.Movies = Movies;
            TempData["Movies"] = Movies;
            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFoundResult();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        [ActionName("EditMovie")]
        public ActionResult Edit(int movieId) {
            return Content("ID " + movieId);
        }
        //? check the varaible as nullable
        public ActionResult Index(int? pageIndex, string sortBy) {

            if (!pageIndex.HasValue) { pageIndex = 1; }
            if (String.IsNullOrWhiteSpace(sortBy)) { sortBy = "Name"; }

            return Content(String.Format("pageIndex = {0}&sortBy={1}", pageIndex, sortBy));
        }

        /*//Custom routing - Simple
        public ActionResult ByReleaseDate(int year, int month) {

            return Content(year + "/" + month);
        
        }*/
        //Custom routing - Attribute - They are more powerful
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month) {
            return Content("Attribute Routing  "+year + "/" + month);
        
        }
    }
}   