using System;
using System.Collections.Generic;

//this template was everywhere and i don't quite fully get why...
namespace MovieTrackerApp { //app name??

    class Program {
        // RA Library?? intialises the master list.
        private List<Movie> movies;

        // enumeration: new word!! never learnt this at alevel - kind of a special class that represents a choice
        public enum MovieCategory {
            Watched,
            WantToWatch
        }
        // creating a movie class
        public class Movie { // getters n setters in c#?? interesting...
            public string Title { get; set; }
            public int ReleaseYear { get; set; }
            public int AgeRating { get; set; }
            public string Genre { get; set; }
            public string Language { get; set; } 
            public double Rating { get; set; }
            public MovieCategory Category { get; set; }
        }

        public MovieTrackerApp() {

            movies = new List<Movie>();
        }

            // method to create and add a new movie
            public void AddNewMovie(string title, int releaseYear, int ageRating, string genre, string language, double rating, MovieCategory category) {
                Movie movie = new Movie {
                    Title = title,
                    ReleaseYear = releaseYear,
                    AgeRating = ageRating,
                    Genre = genre,
                    Language = language,
                    Rating = rating,
                    Category = category
                };
                // adds movie to the master list
                movies.Add(movie);
            }
            // private method to FIND a movie within the master list
            private Movie FindMovie(string title) {
                return movies.Find(movie => movie.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                }


            // to move a movie to watched
            public void AddToWatched(string title) {
                Movie movie = FindMovie(title); // calls find movie
                if (movie != null) { 
                    movie.Category = MovieCategory.Watched;
                } else {
                    Console.WriteLine("Not found...");
                }
            }
            // method to rate a movie
            public void RateMovie(string title, double rating) {
                Movie movie = FindMovie(title); // calls find movie
                if (movie != null && movie.Category == MovieCategory.Watched) { // checks if the movie has been watched first or else you cant rate it
                    Console.Write =("How was it? Give it a rating out of 5 Stars:");
                    rating = Console.ReadLine();
                    movie.Rating = rating; // not sure if this can be done more simpler...
                } else {
                    Console.WriteLine("Not found or haven't watched yet...");
                }
            }
            // to print all the movies watched or not watched...
            public void PrintAllWatchedMovies(MovieCategory category) {
                if (catergory = Watched) {
                    foreach (Movie movie in movies where movie.Category = MovieCategory.Watched) {
                        Console.WriteLine($"Title: {movie.Title}");
                        Console.WriteLine($"Release: {movie.ReleaseYear}");
                        Console.WriteLine($"Age Rating: {movie.AgeRating}");
                        Console.WriteLine($"Genre: {movie.Genre}");
                        Console.WriteLine($"Language: {movie.Language}");
                        Console.WriteLine($"User Rated: {movie.Rating}");
                    }
                } if else (category = WantToWatch) {
                    foreach (Movie movie in movies where movie.Category = MovieCategory.WantToWatch) {
                        Console.WriteLine($"Title: {movie.Title}");
                        Console.WriteLine($"Release: {movie.ReleaseYear}");
                        Console.WriteLine($"Age Rating: {movie.AgeRating}");
                        Console.WriteLine($"Genre: {movie.Genre}");
                        Console.WriteLine($"Language: {movie.Language}");
                    }
                } else {
                    Console.WriteLine("Not found...");
                }
            } 

        }

    }