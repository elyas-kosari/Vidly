using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new CustomerViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Wall-e"}
            };
        }
    }
}
