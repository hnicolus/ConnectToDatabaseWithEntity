using System;
using System.Collections.Generic;
using System.Linq;
using MovieCenter.ConsoleApp.Data;
using MovieCenter.ConsoleApp.Models;

namespace MovieCenter.ConsoleApp.Services
{
    public class MovieService
    {
        private readonly MovieCenterDbContext _dbContext;
        public MovieService()
        {
            _dbContext = new MovieCenterDbContext();
        }

        public void Create(Movie movie)
        {
            if (movie == null) throw new NullReferenceException();

            movie.CreatedAt = DateTime.Now;
            movie.PublishedAt = DateTime.Now;
            _dbContext.Movies.Add(movie);

            SaveChanges();
        }

        public Movie Get(int id)
        {
            var movie = _dbContext.Movies.Find(id);
            if (movie == null) throw new NullReferenceException($"Movie with id {id} cannot be found");

            return movie;
        }


        public List<Movie> GetAll()
        {
            var movies = _dbContext.Movies.ToList();
            return movies;
        }

        public void Update(int id, Movie movie)
        {
            var dbMovie = _dbContext.Movies.FirstOrDefault(i => i.Id == id);
            if (dbMovie == null) throw new NullReferenceException($"Movie with Id {id} cannot be found");

            dbMovie.Title = movie.Title;
            dbMovie.Description = movie.Description;
            dbMovie.ModifiedAt = DateTime.Now;

            _dbContext.Movies.Update(dbMovie);

            SaveChanges();
        }

        public bool Delete(int id)
        {
            //Tell DbContext to remove the movie
            var dbMovie = _dbContext.Movies.FirstOrDefault(i => i.Id == id);
            if (dbMovie == null) throw new NullReferenceException($"Movie with Id {id} cannot be found");

            _dbContext.Movies.Remove(dbMovie);
            return SaveChanges();
        }

        private bool SaveChanges()
        {
            return (_dbContext.SaveChanges() > 0);
        }


    }
}