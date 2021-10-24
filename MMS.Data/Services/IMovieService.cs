
using System.Collections.Generic;
using MMS.Data.Models;

namespace MMS.Data.Services
{
    public interface IMovieService
    {
        void Initialise();
        IList<Movie> GetAllMovies(string order=null); // Get all the reciews and created as interface Ilist
        Movie GetMovieById(int id); //Get movie by ID 
        bool DeleteMovie(int id); //Delete movie but fetch the Id that corresponds with it 
        bool UpdateMovie(Movie m); //Model Movie being passed up so it can be implemented to edit the movie
        Movie AddMovie(Movie m); //Model movie to be passed and processed to the controller 
        Review GetReviewById(int id); //Pass the id across to retrieve the Id for the controller 
   
        // Review AddReview(int movieId, Review r); 
        //Pass the id and model movie data to the controller to check
         //I tried it like this and it works. However
         //I wanted to make a note here as it allows me to create
         //Reviews in the details page and displays

        Review AddReview(Review r); //Pass the Review model to the add review so it can be found by the controller and added in 
        bool DeleteReview(int id); //pass the id so the DeleteReview controller can implement the deletion 

        IList<Review> GetAllReviews(); //Get all the reviews and created as interface Ilist - Created this  

    }
}