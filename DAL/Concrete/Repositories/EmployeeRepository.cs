using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.Abstarction.Repositories;
using DAL.Names;
using DAL.Parsers;
using Entities.Concrete;

namespace DAL.Concrete.Repositories
{
    internal class EmployeeRepository : BaseRepository.BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<Employee> GetAll()
        {
            return SqlWrapper.ExecuteReaderWithCallback(CommandType.StoredProcedure, StoredProcedureNames.spGetAllEmployee,
                EmployeeParser.Instance.MakeBuildingResult);
        }

        public IEnumerable<Employee> GetEmployeesByCarId(int carId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ParameterNames.carId,carId)
            };

            return SqlWrapper.ExecuteReaderWithCallback(CommandType.StoredProcedure, StoredProcedureNames.spGetEmployeesByCarId,
                EmployeeParser.Instance.MakeBuildingResult, parameters);
        }

        public void Insert(Employee employee)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ColumnNames.CarId, employee.CarId),
                new SqlParameter(ColumnNames.FirstName, employee.FirstName),
                new SqlParameter(ColumnNames.LastName, employee.LastName),
                new SqlParameter(ColumnNames.Age, employee.Age),
                new SqlParameter(ColumnNames.Gender, employee.Gender)
            };

            SqlWrapper.ExecuteNonQuery(CommandType.StoredProcedure, StoredProcedureNames.spInsertEmployee, parameters);
        }

        public void Delete(int id)
        {
            SqlParameter[] parameter =
            {
                new SqlParameter(ColumnNames.Id, id)
            };

            SqlWrapper.ExecuteNonQuery(CommandType.StoredProcedure, StoredProcedureNames.spDeleteEmployee, parameter);
        }

        public void ChangeCar(int employeeId, int newCarId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ParameterNames.employeeId, employeeId),
                new SqlParameter(ParameterNames.newCarId, newCarId)
            };

            SqlWrapper.ExecuteNonQuery(CommandType.StoredProcedure, StoredProcedureNames.spUpdateEmployeeCar, parameters);
        }

        public string GetEmployeeSalaryOfDay(int employeeId, string date)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ParameterNames.employeeId, employeeId),
                new SqlParameter(ParameterNames.date,date)
            };

            return (string)SqlWrapper.ExecuteScalar(CommandType.StoredProcedure, StoredProcedureNames.spGetCarIncomeOfDay, parameters);
        }
    }
}
