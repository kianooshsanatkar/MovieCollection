using System.Data.Entity;
using MovieCollection.Domain.Entities;

namespace MovieCollection.DataAccess.Repository
{
    public class MovieContext : DbContext
    {
        public MovieContext()
        {

        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }

        
    }
}
