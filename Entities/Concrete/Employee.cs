using Entities.Abstarction;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public char Gender { get; set; }
    }
}
