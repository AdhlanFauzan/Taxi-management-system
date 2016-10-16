using System;
using System.Data.SqlClient;
using DAL.Names;
using Entities.Concrete;

namespace DAL.Parsers
{
    internal class EmployeeParser
    {
        private EmployeeParser() { }

        public Employee MakeBuildingResult(SqlDataReader reader)
        {
            var model = new Employee
            {
                Id = Convert.ToInt32(reader[ColumnNames.Id]),
                CarId = Convert.ToInt32(reader[ColumnNames.CarId]),
                FirstName = reader[ColumnNames.FirstName].ToString(),
                LastName = reader[ColumnNames.LastName].ToString(),
                Age = Convert.ToInt32(reader[ColumnNames.Age]),
                Gender = Convert.ToChar(reader[ColumnNames.Gender])
            };

            return model;
        }

        public static EmployeeParser Instance => _instance ?? (_instance = new EmployeeParser());

        private static EmployeeParser _instance;
    }
}
