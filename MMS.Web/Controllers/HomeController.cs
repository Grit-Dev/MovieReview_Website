using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MMS.Web.Models;

namespace MMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(); //Return the view of the index page
        }

        //Added some extra details heres to the about page 
        public IActionResult About()
        {
             var about = new AboutViewModel { //using the AboutViewModel  to include additional messaged to the about
                Message = "Our mission is to allow anyone to use our site to add movies freely, and " +
                "to leave reviews. Why? We believe the best reviewer is everyone and not just the critics!" +
                " Not only that is a great place to browse movies and find movies you have never seen before!",
                Formed = new DateTime(2021,03,24),
                TitleOfCreator = "Founder & Creator",
                NameOfCreator = "Paul McGinley",
                InfoOnCreator ="For more info:",
                Url = "https://javahalla.github.io/SamplePageforMVCAssignment/"
             };
            return View(about); //return the about the the view 
            
        }

        public IActionResult Privacy()
        {
            return View(); //return the privacy to view 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
