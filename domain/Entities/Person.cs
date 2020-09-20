using MovieCollection.Domain.CoreDomain;

namespace MovieCollection.Domain.Entities
{
    public class Person : Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }
        public string Country { get; set; }
        public Sexes Sex { get; set; }
        public string Status { get; set; }
    }
}