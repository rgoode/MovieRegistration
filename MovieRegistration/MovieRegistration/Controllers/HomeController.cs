using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieRegistration.Models;
using MovieRegistration.Models.Movie;
using MovieRegistration.services;
using Services.DALModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace MovieRegistration.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly MovieContext _movieContext;

        public HomeController(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieRegister()
        {

                return View();
        }

        [HttpPost]
        public ActionResult Create(MovieTable newMovie)
        {

            if (ModelState.IsValid)
            {
                var db= new MovieContext();
                db.Add(newMovie);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(newMovie);
            }
        }
        public IActionResult Result(UserMovieEntry resultView)
        {
            var model = new ResultViewModel(resultView.Movie);
            return View(model);
        }




        [HttpPost]
        //public ActionResult Validate(MovieTable movieEntered)
        //{
        //    if (Validation.IsValid())
        //    {
        //        var Title = Request["Title"];
        //        var credits = Request["credits"].AsInt();
        //        var Year = Request["Year"].AsDateTime();
        //    }
        //    else
        //    {

        //    }
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
