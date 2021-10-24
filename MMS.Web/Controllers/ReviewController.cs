using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MMS.Data.Models;
using MMS.Data.Services;
using MMS.Web.Models;

namespace MMS.Web.Controllers
{
    public class ReviewController : BaseController
    {
        private readonly IMovieService svc;

        public ReviewController()
        {
            svc = new MovieServiceDb(); //getting the DB so I can use it to gather the reviews
        }

        // GET /review/index
        public IActionResult Index()
        {
            // retrieving all the movies
            var reviews = svc.GetAllReviews();

            return View(reviews);
        }

        public IActionResult Details(int id)
        {
            // retrieve review with the id
            var r = svc.GetReviewById(id); ////////// Maybe the problem is here 

            // Check if r is null

            if (r == null)
            {
                Alert("Review not found", AlertType.warning);

                return RedirectToAction(nameof(Index));
            }

            // pass review to the View

            return View(r);  
        }

        // GET /review/delete/{id}
        public IActionResult Delete(int id)
        {

            var r = svc.GetReviewById(id); //getting the review by the id 

            // check the returned review is not null
            if (r == null)
            {
                Alert("Review not found", AlertType.warning);

                return RedirectToAction(nameof(Index));
            }



            return View(r); //passing the review to confirm the deletion of the review
        }

        // POST /movie/delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken] // support writes a unique value to an HTTP-only cookie and then the same value is written to the form. When the page is submitted, an error is raised if the cookie value doesn't match the form value.
        public IActionResult DeleteConfirm(int id)
        {

            svc.DeleteReview(id); //submiting for deletion

            Alert("Review was deleted", AlertType.success); // letting the user know it is deleted

            return RedirectToAction(nameof(Index)); // return the user to the index page
        }
    }
}