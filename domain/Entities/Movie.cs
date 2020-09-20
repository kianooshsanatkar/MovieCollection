using MovieCollection.Domain.CoreDomain;
using System.Collections.Generic;

namespace MovieCollection.Domain.Entities
{
    public class Movie : Entity
    {
        public string Title { get; set; }
        public short Rate { get; set; }
        public IEnumerable<Genres> Genre { get; set; }
        public Person Director { get; set; }
        public IEnumerable<Person> Actors { get; set; }
        public IEnumerable<Tag> Tags { get; set; }

    }
}
