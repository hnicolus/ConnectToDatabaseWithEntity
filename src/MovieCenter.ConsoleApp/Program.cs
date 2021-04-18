using System.Threading;
using System.Text;
using System;
using MovieCenter.ConsoleApp.Models;
using MovieCenter.ConsoleApp.Services;
using System.Collections.Generic;

namespace MovieCenter.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieService = new MovieService();


            //Creating movies

            // var newMovies = new List<Movie>{
            //     new Movie("Olympus", "Fantasy movie about Olympus the Great City"),
            //     new Movie("Prometheus", "Movie about He who stole fire from the Gods"),
            //     new Movie("Thor", "Thor with his Hammer,smashing Good Guys "),
            //     new Movie("Valhalla", "Acient Greek sci fi movie"),
            //     };

            // newMovies.ForEach(movie =>
            // {
            //     movieService.Create(movie);
            // });

            // Fecth All movies in Database
            var movies = movieService.GetAll();
            DisplayMovies(movies);


            //Updating a movie 
            var movieUpdate = movieService.Get(1);
            movieUpdate.Title = "Updated Movie";
            movieUpdate.Description = "Updated Movie Description";

            movieService.Update(1, movieUpdate);
            DisplayMovies(movies);


            //Deleting a movie 
            movieService.Delete(1);
            DisplayMovies(movies);

        }

        private static void DisplayMovies(List<Movie> movies)
        {
            //Display Them on Console
            var sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine("Welcome to Movie Center ,this is Database for movies");
            sb.AppendLine();
            sb.AppendLine(new string('=', 130));
            sb.AppendLine("Id\t\t Title \t\t\t Created At \t\t\t Description");

            movies.ForEach(movie =>
            {
                sb.AppendLine();
                sb.Append($"{movie.Id} \t\t");
                sb.Append($"{movie.Title}\t\t\t");
                sb.Append($"{movie.CreatedAt}\t\t\t");
                sb.Append($"{movie.Description}");
                sb.AppendLine();
            });
            sb.AppendLine(new string('=', 130));

            System.Console.WriteLine(sb.ToString());
        }
    }
}
