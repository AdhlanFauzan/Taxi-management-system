using System.Collections.Generic;
using Entities.Concrete;

namespace DAL.Abstarction.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        IEnumerable<Employee> GetEmployeesByCarId(int carId);

        void Insert(Employee employee);

        void Delete(int id);

        void ChangeCar(int employeeId, int carId);

        string GetEmployeeSalaryOfDay(int employeeId, string date);
    }
}
