using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
                new MovieViewModel { Id = 1, Name = "Your Name", Rating = "5", ReleaseYear = 2016, Genre = "Romance/Drama/Fantasy/Animation" },
                new MovieViewModel { Id = 2, Name = "Garden of Words", Rating = "4", ReleaseYear = 2013, Genre = "Romance/Drama/Animation" },
                new MovieViewModel { Id = 3, Name = "Weathering With You", Rating = "5", ReleaseYear = 2019, Genre = "Romance/Drama/Fantasy/Animation" },
                new MovieViewModel { Id = 4, Name = "Suzume", Rating = "5", ReleaseYear = 2022, Genre = "Romance/Drama/Fantasy/Animation" },
                new MovieViewModel { Id = 5, Name = "5 Centimeters Per Second", Rating = "5", ReleaseYear = 2007, Genre = "Romance/Drama/Animation" },
                new MovieViewModel { Id = 6, Name = "Hello World", Rating = "5", ReleaseYear = 2019, Genre = "Romance/Drama/Sci-Fi/Animation" },
                new MovieViewModel { Id = 7, Name = "A Silent Voice", Rating = "5", ReleaseYear = 2016, Genre = "Romance/Drama/Animation" },
                new MovieViewModel { Id = 8, Name = "Patema Inverted", Rating = "5", ReleaseYear = 2013, Genre = "Action/Drama/Sci-Fi/Animation" },
                new MovieViewModel { Id = 9, Name = "Into the Forest of Fireflies' Light", Rating = "5", ReleaseYear = 2011, Genre = "Drama/Animation" },
                new MovieViewModel { Id = 10, Name = "Princess Mononoke", Rating = "5", ReleaseYear = 1997, Genre = "Action/Drama/Fantasy/Animation" },
                new MovieViewModel { Id = 11, Name = "Maquia: When the Promised Flower Blooms", Rating = "5", ReleaseYear = 2018, Genre = "Drama/Fantasy/Animation" },
                new MovieViewModel { Id = 12, Name = "I Want to Eat Your Pancreas", Rating = "5", ReleaseYear = 2018, Genre = "Romance/Drama/Animation" },
                new MovieViewModel { Id = 13, Name = "Eternal Sunshine of the Spotless Mind", Rating = "5", ReleaseYear = 2004, Genre = "Romance/Drama/Sci-Fi" },
                new MovieViewModel { Id = 14, Name = "The Truman Show", Rating = "5", ReleaseYear = 1998, Genre = "Comedy/Drama/Sci-Fi" },
                new MovieViewModel { Id = 15, Name = "Seeking a Friend for the End of the World", Rating = "5", ReleaseYear = 2012, Genre = "Adventure/Comedy/Drama" },
                new MovieViewModel { Id = 16, Name = "La La Land", Rating = "5", ReleaseYear = 2016, Genre = "Comedy/Drama/Musical" },
                new MovieViewModel { Id = 17, Name = "Her", Rating = "5", ReleaseYear = 2013, Genre = "Romance/Drama/Sci-Fi" },
                new MovieViewModel { Id = 18, Name = "Inception", Rating = "5", ReleaseYear = 2010, Genre = "Action/Adventure/Sci-Fi" },
                new MovieViewModel { Id = 19, Name = "Predestination", Rating = "5", ReleaseYear = 2014, Genre = "Action/Drama/Sci-Fi" },
                new MovieViewModel { Id = 20, Name = "Hereditary", Rating = "5", ReleaseYear = 2018, Genre = "Horror/Drama/Mystery" },
                new MovieViewModel { Id = 21, Name = "Midsommar", Rating = "5", ReleaseYear = 2019, Genre = "Horror/Drama/Mystery" },
                new MovieViewModel { Id = 22, Name = "Talk to Me", Rating = "5", ReleaseYear = 2022, Genre = "Horror/Thriller" },
                new MovieViewModel { Id = 23, Name = "Everything Everywhere All at Once", Rating = "5", ReleaseYear = 2022, Genre = "Action/Adventure/Comedy" },
                new MovieViewModel { Id = 24, Name = "Beau Is Afraid", Rating = "5", ReleaseYear = 2023, Genre = "Comedy/Horror/Drama" },
                new MovieViewModel { Id = 25, Name = "Se7en", Rating = "5", ReleaseYear = 1995, Genre = "Crime/Drama/Mystery" },
                new MovieViewModel { Id = 26, Name = "Knives Out", Rating = "5", ReleaseYear = 2019, Genre = "Crime/Comedy/Drama" },
                new MovieViewModel { Id = 27, Name = "Glass Onion: A Knives Out Mystery", Rating = "5", ReleaseYear = 2022, Genre = "Crime/Comedy/Drama" },
                new MovieViewModel { Id = 28, Name = "500 Days of Summer", Rating = "5", ReleaseYear = 2009, Genre = "Comedy/Romance/Drama" },
                new MovieViewModel { Id = 29, Name = "Yesterday", Rating = "5", ReleaseYear = 2019, Genre = "Comedy/Fantasy/Musical" },
                new MovieViewModel { Id = 30, Name = "Interstellar", Rating = "5", ReleaseYear = 2014, Genre = "Adventure/Drama/Sci-Fi" },
            };
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

