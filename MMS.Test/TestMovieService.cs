

using System;
using System.Linq;
using Xunit;
using MMS.Data.Models;
using MMS.Data.Services;


namespace MMS.Test
{
    public class TestMovieService
    {
        private readonly IMovieService svc;

        public TestMovieService()
        {
            // create and initialise MovieServiceDb service
            svc = new MovieServiceDb();

            svc.Initialise(); //db is running and initalised

        }

        // add tests here - test should ensure your service implementation works
        [Fact]
        public void Test1_GetAllMovies()
        {

            var movies = svc.GetAllMovies();
            var count = movies.Count;

            Assert.Equal(0, count);

        }

        [Fact]
        public void Test2_GetAllMoviesBool_True() //Making sure movies exist 
        {

            bool yes = true;


            var movies = svc.GetAllMovies(); //get all movies

            if (movies != null)
            {
                Assert.True(yes); //SHould not be null as we have pre saved movies 
            }


        }

        [Fact]
        public void Test3_DeleteMovie()
        {
            Movie m1 = new Movie //Creating a movie firstand filling in the required details
            {
                Title = "Paul",
                Director = "Paul",
                Year = 2000,
                Duration = 120,
                Budget = 5000,
                PosterUrl = "https://www.themoviedb.org/tv/1402-the-walking-dead#",
                Genre = Genre.Action,
                Cast = "Paul 1 and Paul 2",
                Plot = "Unit Testing",
               
            };

            var movie = svc.AddMovie(m1); //Adding movie to the db

            var delete = svc.DeleteMovie(movie.Id); // deleting movie from the db 
            var mId = svc.GetMovieById(movie.Id); // fethcing the Id of the movie to check if it really has been deleted 

            Assert.True(delete); // If the movie is deleted it should return back true
            Assert.Null(mId); // Id should be deleted and return a null value 


        }

        [Fact]
        public void Test4_DeleteMovieWhichExists_True()
        {
            Movie m1 = new Movie //Creating a movie firstand filling in the required details
            {
                Title = "Paul",
                Director = "Paul",
                Year = 2000,
                Duration = 120,
                Budget = 5000,
                PosterUrl = "https://www.themoviedb.org/tv/1402-the-walking-dead#",
                Genre = Genre.Action,
                Cast = "Paul 1 and Paul 2",
                Plot = "Unit Testing",
            };
            var movie = svc.AddMovie(m1); //Adding movie to the db

            var delete = svc.DeleteMovie(movie.Id);
            var m11 = svc.GetMovieById(movie.Id); // Trying to retrieve Deleted Movie

            Assert.True(delete); // Deleted movie should be deleted and I am checking if this is true
            Assert.Null(m11); // Id should be null as it should not exist


        }

        [Fact]
        public void Test5_DeleteMovieWhichExists_True()
        {
            Movie m1 = new Movie //Creating a movie firstand filling in the required details
            {
                Title = "Paul",
                Director = "Paul",
                Year = 2000,
                Duration = 120,
                Budget = 5000,
                PosterUrl = "https://www.themoviedb.org/tv/1402-the-walking-dead#",
                Genre = Genre.Action,
                Cast = "Paul 1 and Paul 2",
                Plot = "Unit Testing",
            };
            var movie = svc.AddMovie(m1); //Adding movie to the db

            var delete = svc.DeleteMovie(movie.Id);
            var movies = svc.GetAllMovies(); // Trying to retrieve Deleted Movie

            Assert.Equal(0, movies.Count); // should be zero


        }
        [Fact]
        public void Test6_DeleteMovieWhichDoesNotExist_NoCountChange()
        {
            Movie m1 = new Movie //Creating a movie firstand filling in the required details
            {
                Title = "Paul",
                Director = "Paul",
                Year = 2000,
                Duration = 120,
                Budget = 5000,
                PosterUrl = "https://www.themoviedb.org/tv/1402-the-walking-dead#",
                Genre = Genre.Action,
                Cast = "Paul 1 and Paul 2",
                Plot = "Unit Testing",
            };
            var movie = svc.AddMovie(m1); //Adding movie to the db

            svc.DeleteMovie(0);
            var movies = svc.GetAllMovies(); // Retrieve all the movies 

            Assert.Equal(1, movies.Count); // should be one movie


        }

        [Fact]
        public void Test7_EditingTheMovieForUpdate_True()
        {
            Movie m1 = new Movie //Creating a movie firstand filling in the required details
            {
                Title = "Paul",
                Director = "Paul",
                Year = 2000,
                Duration = 120,
                Budget = 5000,
                PosterUrl = "https://www.themoviedb.org/tv/1402-the-walking-dead#",
                Genre = Genre.Action,
                Cast = "Paul 1 and Paul 2",
                Plot = "Unit Testing",
            };
            var movie = svc.AddMovie(m1); //Adding movie to the db

            movie.Title = "Paul2"; //Updating the movie variables
            movie.Title = "Paul2";
            movie.Director = "Paul2";
            movie.Year = 2500;
            movie.Duration = 110;
            movie.Budget = 5500;
            movie.PosterUrl = "https://www.themoviedb.org/tv/1402-the-walking-dead#";
            movie.Genre = Genre.Comedy;
            movie.Cast = "Paul 11 and Paul 22";
            movie.Plot = "Unit Testinggggggg";

          
            svc.UpdateMovie(movie); //updating the movie

            //Checking the movies is not null and that the new update equals exactly as what is needed
            Assert.NotNull(movie);
            Assert.Equal("Paul2", movie.Title);
            Assert.Equal("Paul2", movie.Director);
            Assert.Equal(2500, movie.Year);
            Assert.Equal(110, movie.Duration);
            Assert.Equal(5500, movie.Budget);
            Assert.Equal("https://www.themoviedb.org/tv/1402-the-walking-dead#", movie.PosterUrl);
            Assert.Equal(Genre.Comedy, movie.Genre);
            Assert.Equal("Paul 11 and Paul 22", movie.Cast);
            Assert.Equal("Unit Testinggggggg", movie.Plot);


        }

        [Fact]
        public void Test8_AddingMovie()
        {
            Movie m1 = new Movie //Creating a movie firstand filling in the required details
            {
                Title = "Paul",
                Director = "Paul",
                Year = 2000,
                Duration = 120,
                Budget = 5000,
                PosterUrl = "https://www.themoviedb.org/tv/1402-the-walking-dead#",
                Genre = Genre.Action,
                Cast = "Paul 1 and Paul 2",
                Plot = "Unit Testing",
            };
            var movie = svc.AddMovie(m1); //Adding movie to the db

            Assert.NotNull(movie);
            Assert.Equal(movie.Id, movie.Id); //Id check
            Assert.Equal("Paul", movie.Title); //title check
            Assert.Equal("Paul", movie.Director); //director check
            Assert.Equal(2000, movie.Year); // year check
            Assert.Equal(120, movie.Duration); // duration check
            Assert.Equal(5000, movie.Budget); // budget check
            Assert.Equal("https://www.themoviedb.org/tv/1402-the-walking-dead#", movie.PosterUrl); //posterurl check
            Assert.Equal(Genre.Action, movie.Genre); // genre check
            Assert.Equal("Paul 1 and Paul 2", movie.Cast); //cast check 
            Assert.Equal("Unit Testing", movie.Plot); //



        }

        //[Fact]
        //public void Test9_AddingReview()
        //{

        //    Movie m1 = new Movie //Creating a movie firstand filling in the required details
        //    {
        //        Title = "Paul",
        //        Director = "Paul",
        //        Year = 2000,
        //        Duration = 120,
        //        Budget = 5000,
        //        PosterUrl = "https://www.themoviedb.org/tv/1402-the-walking-dead#",
        //        Genre = Genre.Action,
        //        Cast = "Paul 1 and Paul 2",
        //        Plot = "Unit Testing",

        //    };


        //   var m11 = svc.AddMovie(m1); //Adding movie to the db
        //    var m22 = svc.GetMovieById(m11.Id);

        //    Review r1 = new Review //Creating a Review first and filling in the required details
        //    {
               
        //        Name = "Paul McGinley",
        //        CreatedOn = new DateTime(2000, 01, 10),
        //        Comment = "This is a comment I am testing test testing testing testing",
        //        Rating = 5,
        //        MovieId = m22.Id

             
               
        //    };


        //    svc.AddReview(m22.Id, r1); //Adding movie to the db


        //}


       
        /// <summary>
        /// ///////////////////////////////////////////////////////// WOrking on this
        /// </summary>

        [Fact]
        public void Test90_Second__AddingReview2_Method()
        {

            Movie m1 = new Movie //Creating a movie firstand filling in the required details
            {
                Title = "Paul",
                Director = "Paul",
                Year = 2000,
                Duration = 120,
                Budget = 5000,
                PosterUrl = "https://www.themoviedb.org/tv/1402-the-walking-dead#",
                Genre = Genre.Action,
                Cast = "Paul 1 and Paul 2",
                Plot = "Unit Testing",

            };


            var m11 = svc.AddMovie(m1); //Adding movie to the db
          

            Review r1 = new Review //Creating a Review first and filling in the required details
            {
                Name = "Paul McGinley",
                CreatedOn = new DateTime(2000, 01, 10),
                Comment = "This is a comment I am testing test testing testing testing",
                Rating = 5,
                MovieId = m11.Id

            };

            var equalR = svc.AddReview(r1); //Adding movie to the db

            Assert.NotNull(equalR); //is not emplty 
            Assert.Equal(equalR.Id, equalR.Id); //Id check
            Assert.Equal(equalR.Name, equalR.Name); //Name check
            Assert.Equal(equalR.CreatedOn, equalR.CreatedOn); //Creaton check
            Assert.Equal(equalR.Comment, equalR.Comment); //Comment check
            Assert.Equal(equalR.Rating, equalR.Rating); // Rating check

        }




        [Fact]
        public void Test10_DeleteReview()
        {

            Movie m1 = new Movie //Creating a movie firstand filling in the required details
            {
                Title = "Paul",
                Director = "Paul",
                Year = 2000,
                Duration = 120,
                Budget = 5000,
                PosterUrl = "https://www.themoviedb.org/tv/1402-the-walking-dead#",
                Genre = Genre.Action,
                Cast = "Paul 1 and Paul 2",
                Plot = "Unit Testing",

            };


            var m11 = svc.AddMovie(m1); //Adding movie to the db


            Review r1 = new Review //Creating a Review first and filling in the required details
            {

                Name = "Paul McGinley",
                CreatedOn = new DateTime(2000, 01, 10),
                Comment = "This is a comment I am testing test testing testing testing",
                Rating = 5,
                MovieId = m11.Id



            };

            var equalR = svc.AddReview(r1); //Adding movie to the db

            Assert.NotNull(equalR); //is not emplty 
            Assert.Equal(equalR.Id, equalR.Id); //Id check
            Assert.Equal(equalR.Name, equalR.Name); //Name check
            Assert.Equal(equalR.CreatedOn, equalR.CreatedOn); //Creaton check
            Assert.Equal(equalR.Comment, equalR.Comment); //Comment check
            Assert.Equal(equalR.Rating, equalR.Rating); // Rating check

            var delete = svc.DeleteReview(equalR.Id);
            var nonExist = svc.GetReviewById(equalR.Id);

            Assert.True(delete); // Checking to see if review  is deleted - Should be true
            Assert.Null(nonExist); //Id should not exist


        }

        [Fact]
        public void Test11_GetAllReviews()
        {

            var reviews = svc.GetAllReviews();
            var count = reviews.Count;

            Assert.Equal(0, count); //Testing to check all reviews are there 

        }




    }
}
    