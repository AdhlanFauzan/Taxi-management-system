using System.Collections.Generic;
using Entities.Concrete;

namespace DAL.Abstarction.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAll();

        void Insert(Car car);

        void Delete(int carId);

        void UpdateCarState(int carId, string newState);

        string GetCarIncomeOfDay(int carId, string date);
    }
}
