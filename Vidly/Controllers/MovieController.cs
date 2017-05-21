using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Empty.Models;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {

        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
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
            var movies = _context.Movies.Include(m => m.Genre).ToList();
        
            return View(movies);

        }

        public ActionResult Detail(int? id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.ID  == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }
        
        

    }
}