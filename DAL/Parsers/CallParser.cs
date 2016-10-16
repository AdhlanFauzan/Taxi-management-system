using System;
using System.Data.SqlClient;
using DAL.Names;
using Entities.Concrete;

namespace DAL.Parsers
{
    internal class CallParser
    {
        private CallParser() { }

        public Call MakeBuildingResult(SqlDataReader reader)
        {
            var model = new Call
            {
                Id = Convert.ToInt32(reader[ColumnNames.Id]),
                CarId = Convert.ToInt32(reader[ColumnNames.CarId]),
                DeparturePlace = reader[ColumnNames.DeparturePlace].ToString(),
                ArrivalPlace = reader[ColumnNames.ArrivalPlace].ToString(),
                Distance = Convert.ToInt32(reader[ColumnNames.Distance]),
                Price = Convert.ToInt32(reader[ColumnNames.Price]),
                Date = (Convert.ToDateTime(reader[ColumnNames.Date])).ToString("d")
            };

            return model;
        }

        public static CallParser Instance => _instance ?? (_instance = new CallParser());

        private static CallParser _instance;
    }
}
