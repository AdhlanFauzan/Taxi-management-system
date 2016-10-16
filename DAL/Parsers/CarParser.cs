using System;
using System.Data.SqlClient;
using DAL.Names;
using Entities.Concrete;

namespace DAL.Parsers
{
    internal class CarParser
    {
        private CarParser() { }

        public Car MakeBuildingResult(SqlDataReader reader)
        {
            var model = new Car
            {
                Id = Convert.ToInt32(reader[ColumnNames.Id]),
                LicensePlate = reader[ColumnNames.LicensePlate].ToString(),
                Model = reader[ColumnNames.Model].ToString(),
                Mileage = Convert.ToInt32(reader[ColumnNames.Mileage]),
                State = reader[ColumnNames.State].ToString()
            };

            return model;
        }

        public static CarParser Instance => _instance ?? (_instance = new CarParser());

        private static CarParser _instance;
    }
}
