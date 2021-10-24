using Microsoft.AspNetCore.Mvc;
using MMS.Data.Models;
using MMS.Data.Services;
using System;


namespace MMS.Web.Controllers
{
    public class MovieController : BaseController
    {
        private readonly IMovieService svc;

        public MovieController()
        {
            svc = new MovieServiceDb();
        }
        
        

        //GET //Movie
        public IActionResult Index()
        {
            var movies = svc.GetAllMovies();
         

            return View(movies);

        }

        public IActionResult OrderByTitle() // Controller action created so can create a view and in their order the table by title
        {
            var movies = svc.GetAllMovies();

            return View(movies);

        }
        public IActionResult OrderByYear() // Controller action created so can create a view and in their order the table by year
        {
            var movies = svc.GetAllMovies();

            return View(movies);

        }
        public IActionResult OrderByDirector() // Controller action created so can create a view and in their order the table by Director
        {
            var movies = svc.GetAllMovies();

            return View(movies);

        }

        public IActionResult Details(int id)
        {
            //retrieve the movie with specified id from the service
            var m = svc.GetMovieById(id);

            //check if m is null and return notFound 

            if (m == null)
            {
                // alert letting the user that the movie was not found
                Alert("Movie not found", AlertType.warning);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(m);
            }

        }
      

        // GET //Movie/Create
        public IActionResult Create()
        {
            //Displaying blank form to create a new movie
            var m = new Movie();
            return View(m);
        }

        //POST /Movie/Create
        [HttpPost]
        [ValidateAntiForgeryToken] // support writes a unique value to an HTTP-only cookie and then the same value is written to the form. When the page is submitted, an error is raised if the cookie value doesn't match the form value.
        public IActionResult Create(Movie m)
        {


            //THis will complete the POST action and add the movie
            if (ModelState.IsValid)
            {

                svc.AddMovie(m); //Add the movie if it is valid

                Alert("Movie Was Created", AlertType.success); //alert the user if the movie added was successful

                return RedirectToAction(nameof(Index)); // If valid and created then show the user the movie index page
            }

            return View(m);

           


        }

        public IActionResult Edit(int id)
        {
            //load the movie using the service

            var m = svc.GetMovieById(id);

            if (m == null)
            {
                //check if m is null and alert

                Alert("Movie Not found", AlertType.warning); //inform the user the movie was not found

                return RedirectToAction(nameof(Index));

            }
            else
            {
                return View(m);
            }

           
        }


        [HttpPost]
        [ValidateAntiForgeryToken] // support writes a unique value to an HTTP-only cookie and then the same value is written to the form. When the page is submitted, an error is raised if the cookie value doesn't match the form value.
        public IActionResult Edit(int id, Movie m)
        {
            // verify a movie is valid
            if (ModelState.IsValid)
            {
                //pass data to service to update

                svc.UpdateMovie(m);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                // resdisplay the form for editing as valdiation errors

                return View(m);
            }
        }

        //GET /Movie/Delete/{id}
        public IActionResult Delete(int id)
        {
            var m = svc.GetMovieById(id); // load the movies using the servie

            //check the returned movie is not null and if so an alert will inform the user

            if (m == null)
            {
                Alert("Movie not found", AlertType.warning);

                return RedirectToAction(nameof(Index));

            }
            else
            {
                return View(m);
            }

        }

        //POST /Movie/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken] // support writes a unique value to an HTTP-only cookie and then the same value is written to the form. When the page is submitted, an error is raised if the cookie value doesn't match the form value.

        public IActionResult DeleteConfirm(int id)
        {
            // delete student via service
            svc.DeleteMovie(id);

            Alert($"Movie deleted successfully", AlertType.success); //Decided to hide the ID as the viewer does not nee to see the unique key, nor would he/she understand why a random number is appearing 
            //Let the User know movie has been deleted

            return RedirectToAction(nameof(Index));
            //redirect to the index View
            
        }

  

        //--------------------------------------------------------------Review Section-------------------------------------------------------------------------------------



        //GET /Movie/Create Review
        public IActionResult CreateReview(int id)
        {
            var m = svc.GetMovieById(id); //Checking the returned movie

            if (m == null)
            {
                Alert($"No such movie exists", AlertType.warning); //Letting the user know the movie does not exist and removed the ID to be displayed

                return RedirectToAction(nameof(Index)); // return to the index

            }
            else
            {
                //Create the Review View model and populate the MovieId property

                var r = new Review { MovieId = id };

                return View(r);
            }
        }

        //POST / Movie //Review
        [HttpPost]
        [ValidateAntiForgeryToken] // support writes a unique value to an HTTP-only cookie and then the same value is written to the form. When the page is submitted, an error is raised if the cookie value doesn't match the form value.
        public IActionResult CreateReview( Review r)
        {


            //Check the returned movie is not null and if Alert created to inform the user
            if (ModelState.IsValid)
            {
                Alert($"Review is created", AlertType.success); //Notify the user that the review was created!

                svc.AddReview(r);  //If I remove this my review will not be added 

                return RedirectToAction(nameof(Details), new { Id = r.MovieId }); // return user back to index
            }
            else
            {
                Alert($"Review is not created!", AlertType.warning);
                return View(r);
            }
        
            
        }

       
        // Please do note that I have two controllers with the same Delete and DeleteReview 
        // The reasoning is I want a review index section for the user to see all the reviews and the 
        //title of the movie that is selected to.
        //Also in the home controller I want to give the user to go into the movie and delete the review from there
        //as well and bring them back to the home index as well to view the movies.
        //Created options for both to give an overall better experience 


        public IActionResult DeleteReview(int id)
        {

            var r = svc.GetReviewById(id); //getting the review by the id 

            // check the returned review is not null
            if (r == null)
            {
                Alert("Review not found", AlertType.warning);

                return RedirectToAction(nameof(r));
            }



            return View(r); //passing the review to confirm the deletion of the review
        }

        // POST /movie/delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken] // support writes a unique value to an HTTP-only cookie and then the same value is written to the form. When the page is submitted, an error is raised if the cookie value doesn't match the form value.
        public IActionResult DeleteReviewConfirm(int id)
        {

            svc.DeleteReview(id); //submiting for deletion

            Alert("Review was deleted", AlertType.success); // letting the user know it is deleted

            return RedirectToAction(nameof(Index)); // return the user to the index page
        }


    }
}
