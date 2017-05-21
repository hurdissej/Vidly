using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {


        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Name = "Shrek"},
                new Movie {Name = "Wall-E"}
            };
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shreks!"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Martin Johnson"},
                new Customer {Name = "Johnny Wilkonson"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            
            return View(viewModel);
        }

       
        public ActionResult Index()
        {
            var movies = GetMovies();
        
            return View(movies);

        }
        
        

    }
}