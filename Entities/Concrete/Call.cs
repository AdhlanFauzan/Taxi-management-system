using Entities.Abstarction;

namespace Entities.Concrete
{
    public class Call : IEntity
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public string DeparturePlace { get; set; }

        public string ArrivalPlace { get; set; }

        public int Distance { get; set; }

        public double Price { get; set; }

        public string Date { get; set; }
    }
}
