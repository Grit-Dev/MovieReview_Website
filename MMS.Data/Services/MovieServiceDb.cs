using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MMS.Data.Models;
using MMS.Data.Repositories;


namespace MMS.Data.Services
{
    // create IMovieService implementation called MovieServiceDb
    // using the provided Entityframework Repository (MovieDbContext)

    public class MovieServiceDb : IMovieService
    {
        private readonly MovieDbContext db;

        public MovieServiceDb()
        {
            db = new MovieDbContext();
        }

        // ------------------------------- Movie Related Operations ----------------------------------------------------------- //

        public void Initialise()
        {
            db.Initialise();
        }

        public IList<Movie> GetAllMovies(string order = null)
        {
            //retrieve a list of movies

            return db.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            // Retrieve movie by Id 

            return db.Movies.Include(e => e.Reviews).FirstOrDefault(e => e.Id == id);

        }

        public bool DeleteMovie(int id)
        {
            //Checking first to see if the movie exists
            var movie = GetMovieById(id);

            if (movie == null)
            {

                return false;

                //if the movie does not exist - return false

            }
            else
            {
                // remove the movie, inputing the var movie into the parenthesis

                db.Movies.Remove(movie);
                db.SaveChanges(); // Save changes to the database 

                return true; // return true
            }

        }

        public bool UpdateMovie(Movie updated)
        {
            //check if movie exists
            var movie = GetMovieById(updated.Id);

            if (movie == null)
            {
                return false;
            }
            else
            {
                //Update the movie 

                movie.Title = updated.Title;
                movie.Director = updated.Director;
                movie.Year = updated.Year;
                movie.Duration = updated.Duration;
                movie.Budget = updated.Budget;
                movie.PosterUrl = updated.PosterUrl;
                movie.Genre = updated.Genre;
                movie.Cast = updated.Cast;
                movie.Plot = updated.Plot;

                //movie.Rating = updated.Rating; //Come back to this

                //movie.Rating = updated.Rating; - I do not think I need this bit. 

                db.SaveChanges(); // SaveChanges to database

                return true; //return true

            }


        }

        public Movie AddMovie(Movie m) //
        {
            var existing = GetMovieById(m.Id);



            if (existing != null)
            {
                return null;
            }
            else
            {

                var movie = new Movie
                {
                    Title = m.Title,
                    Director = m.Director,
                    Year = m.Year,
                    Duration = m.Duration,
                    Budget = m.Budget,
                    PosterUrl = m.PosterUrl,
                    Genre = m.Genre,
                    Cast = m.Cast,
                    Plot = m.Plot,
                };


                db.Movies.Add(movie);
                db.SaveChanges();

                return movie;
            }


        }


        //-------------------------------------------- Review Management ---------------------------------------


        //
        // THis is what I would of used to test my second way of adding a review 
        // I decided to leave this in for 


        //public Review AddReview(int movieId, Review r) //Changing this to add review for now 
        //{
        //    var movie = GetMovieById(movieId);

        //    if (movie == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        var review = new Review
        //        {
        //            Name = r.Name,
        //            CreatedOn = r.CreatedOn,
        //            Comment = r.Comment,
        //            Rating = r.Rating,
        //            MovieId = movieId

        //        };

        //        movie.Reviews.Add(review);
        //        db.SaveChanges();

        //        return review;


        //    }


        //}

        public Review GetReviewById(int id)
        {

            var review = db.Movies.SelectMany(e => e.Reviews).FirstOrDefault(e => e.Id == id);

            // get from the db. movies model and SelectMany(Projects each element of a sequence to an IEnumerable<T> and flattens the resulting sequences into one sequence.) IE. the reviews and get the first or default of the id

            return review;
        }

        public Review AddReview(Review r)    
        {
            var existing = GetReviewById(r.Id);

            if (existing != null)
            {
                return null;
            }
            else
            {
                var review = new Review
                {
                    MovieId = r.Id, // This is to ensure the foreign key is set
                    Name = r.Name,
                    CreatedOn = r.CreatedOn,
                    Comment = r.Comment,
                    Rating = r.Rating
                };

                db.Reviews.Add(review);
                db.SaveChanges();

                return review;
            }



        }

        
        public bool DeleteReview(int id)
        {
            //finding the review
            var review = GetReviewById(id);

            // if ticket is not found return null
            if (review == null)
            {
                return false;
            }
            else
            {
                //var result = review.Movie.Reviews.Remove(review);

                db.Reviews.Remove(review); //Come back to this if this does not work
                db.SaveChanges();

                return true;

            }
        }


        public IList<Review> GetAllReviews()
        {
            return db.Reviews.Include(r => r.Movie).ToList(); //Get all reviews from the db, and include movie, to a list!

        }

          

    }



}