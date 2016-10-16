using DAL.Abstarction.Repositories;

namespace DAL.Abstarction.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICallRepository CallRepository { get; }

        ICarRepository CarRepository { get; }

        IEmployeeRepository EmployeeRepository { get; }
    }
}
