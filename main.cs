using System;
using System.Collections.Generic;

//this template was everywhere and i don't quite fully get why...

namespace MovieTrackerApp { //app name??
    class Program {
        // enumeration: new word!! never learnt this at alevel - kind of a special class that represents a choice
        public enum MovieCategory {
            Watched,
            WantToWatch
        }

        public class Movie {
            public string Title { get; set; }
            public int ReleaseYear { get; set; }
            public string AgeRating { get; set; }
            public double Rating { get; set; }
            public MovieCategory Category { get; set; }
        }


        static void Main(string[] args) {

        }



    }
}