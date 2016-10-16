using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAL.Abstarction.Repositories;
using DAL.Names;
using DAL.Parsers;
using Entities.Concrete;

namespace DAL.Concrete.Repositories
{
    internal class CarRepository : BaseRepository.BaseRepository, ICarRepository
    {
        public CarRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<Car> GetAll()
        {
            return SqlWrapper.ExecuteReaderWithCallback(CommandType.StoredProcedure, StoredProcedureNames.spGetAllCars,
                CarParser.Instance.MakeBuildingResult);
        }

        public void Insert(Car car)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ColumnNames.LicensePlate, car.LicensePlate),
                new SqlParameter(ColumnNames.Model, car.Model),
                new SqlParameter(ColumnNames.Mileage, car.Mileage),
                new SqlParameter(ColumnNames.State,car.State)
            };

            SqlWrapper.ExecuteNonQuery(CommandType.StoredProcedure, StoredProcedureNames.spInsertCar, parameters);
        }

        public void Delete(int carId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ParameterNames.carId, carId)
            };

            SqlWrapper.ExecuteNonQuery(CommandType.StoredProcedure, StoredProcedureNames.spDeleteCar, parameters);
        }

        public void UpdateCarState(int carId, string newState)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ParameterNames.carId, carId),
                new SqlParameter(ParameterNames.newState, newState)
            };

            SqlWrapper.ExecuteNonQuery(CommandType.StoredProcedure, StoredProcedureNames.spUpdateCarState, parameters);
        }

        public string GetCarIncomeOfDay(int carId, string date)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ParameterNames.carId,carId),
                new SqlParameter(ParameterNames.date,date)
            };

            object o = SqlWrapper.ExecuteScalar(CommandType.StoredProcedure, StoredProcedureNames.spGetCarIncomeOfDay,
                parameters);

            return o is DBNull ? "0" : (string)o;
        }
    }
}
