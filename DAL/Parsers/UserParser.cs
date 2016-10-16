using System;
using System.Data.SqlClient;
using DAL.Names;
using Entities.Concrete;

namespace DAL.Parsers
{
    internal class UserParser
    {
        private UserParser() { }

        public User MakeBuildingResult(SqlDataReader reader)
        {
            var model = new User
            {
                Id = Convert.ToInt32(reader[ColumnNames.Id]),
                FirstName = reader[ColumnNames.FirstName].ToString(),
                LastName = reader[ColumnNames.LastName].ToString(),
                Login = reader[ColumnNames.Login].ToString()
            };

            return model;
        }

        public static UserParser Instance => _instance ?? (_instance = new UserParser());

        private static UserParser _instance;
    }
}
