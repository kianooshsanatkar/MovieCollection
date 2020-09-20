using MovieCollection.DataAccess.BaseRepository;
using MovieCollection.DataAccess.IBaseRepository;
using MovieCollection.Domain.Entities;
using System;

namespace MovieCollection.DataAccess.Repository
{
    public class MovieUnitOfWork : IUnitOfWork
    {
        private readonly MovieContext _context;
        public IRepository<Movie> MovieRepo { get; private set; }
        public IRepository<Person> PersonRepo { get; private set; }
        public IRepository<Tag> TagRepo { get; private set; }
        public IRepository<Genres> GenreRepo { get; private set; }

        public MovieUnitOfWork(MovieContext context)
        {
            _context = context;
            MovieRepo = new Repository<Movie>(_context);
            PersonRepo = new Repository<Person>(_context);
            TagRepo = new Repository<Tag>(_context);
            GenreRepo = new Repository<Genres>(_context);
        }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
