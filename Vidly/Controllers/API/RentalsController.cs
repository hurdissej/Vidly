using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Empty.Models;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class RentalsController : ApiController
    {

        private ApplicationDbContext _context;
        
        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // POST api/Rentals
        [HttpPost]
        public IHttpActionResult Post(RentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

           var movies = _context.Movies.Where(m => newRental.MovieId.Contains(m.ID));
            
            if (movies.Any())
            {
                return BadRequest("No movies with that ID available");
            }
            
            foreach (var movie in movies)
            {

                if (movie.NumberAvailable > 0)
                {
                    var rental = new Rentals
                    {
                        Customer = customer,
                        Movie = movie,
                        DateRented = DateTime.Now,
                    };

                    movie.NumberAvailable--;
                    _context.Rentals.Add(rental);
                }
                else
                {
                    return BadRequest("Movie is not available");
                }
            }

            _context.SaveChanges();

            return Ok();

        }
        
    }
}