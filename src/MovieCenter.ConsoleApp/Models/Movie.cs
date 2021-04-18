using System;

namespace MovieCenter.ConsoleApp.Models
{
    public class Movie
    {
        public Movie(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}