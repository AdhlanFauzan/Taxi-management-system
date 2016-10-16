using System.Collections.Generic;
using Entities.Concrete;

namespace DAL.Abstarction.Repositories
{
    public interface ICallRepository
    {
        IEnumerable<Call> GetAll();

        void Insert(Call call);

        void Delete(int id);

        IEnumerable<Call> GetCallsByCarId(int carId);

        string DayInfo(string date);
    }
}
