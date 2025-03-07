﻿using System;
namespace BSIT3L_Movies.Models
{
    
	public class MovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string Form {  get; set; }
        public string Poster { get; set; }
        public string Trailer { get; set; }
        public string Synopsis { get; set; }
    }
}

