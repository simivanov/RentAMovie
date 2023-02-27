using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentAMovie.Models;
using RentAMovie.ViewModels;

namespace RentAMovie.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {

            var movie = GetMovies();


            return View(movie);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "The Wall"}
            };
        }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/release/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        

    }
}