using Entities.Abstarction;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public string LicensePlate { get; set; }

        public string Model { get; set; }

        public string State { get; set; }

        public int Id { get; set; }

        public int Mileage { get; set; }

        public bool Enabled { get; set; }
    }
}
