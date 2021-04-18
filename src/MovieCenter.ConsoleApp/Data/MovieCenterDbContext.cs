using Microsoft.EntityFrameworkCore;
using MovieCenter.ConsoleApp.Models;

namespace MovieCenter.ConsoleApp.Data
{
    public class MovieCenterDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=OCTIAN\SQLEXPRESS;Database=MovieCenterDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}