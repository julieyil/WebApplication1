using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        //public IActionResult Random()
        //{
        //    var movie = new Movie() {Name = "Shrek!"};
        //    var customers = new List<Customer>
        //    {
        //        new Customer{Name="Customer 1"},
        //        new Customer{Name="Customer 2"}
        //    };

        //    var ViewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };

            
        //    return View(ViewModel);

        //    //return Content("hello world");
        //    //return HttpNotFound();
        //    //return new EmptyResult();
        //}

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id=1, Name="Shrek!"},
                new Movie{Id=2, Name="Joker"}
            };
        }
    }
}