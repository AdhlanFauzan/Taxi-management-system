using DAL.Abstarction.Repositories;
using DAL.Abstarction.UnitOfWork;
using DAL.Concrete.Repositories;

namespace DAL.Concrete.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(string connection)
        {
            _connection = connection;
        }

        public ICallRepository CallRepository => _callRepository ?? (_callRepository = new CallRepository(_connection));

        public ICarRepository CarRepository => _carRepository ?? (_carRepository = new CarRepository(_connection));

        public IEmployeeRepository EmployeeRepository => _employeeRepository ?? (_employeeRepository = new EmployeeRepository(_connection));

        private ICallRepository _callRepository;
        private ICarRepository _carRepository;
        private IEmployeeRepository _employeeRepository;
        private readonly string _connection;
    }
}
