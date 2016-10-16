using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Concrete.SQL
{
    public class SqlCommandWrapper
    {
        public SqlCommandWrapper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<T> ExecuteReaderWithCallback<T>(CommandType commandType,
           string commandText, Func<SqlDataReader, T> callback, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(commandText, connection) { CommandType = commandType })
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    command.CommandTimeout = 0;

                    var reader = command.ExecuteReader();
                    var list = new List<T>();

                    using (reader)
                    {
                        while (reader.Read())
                        {
                            var item = callback(reader);
                            if (!Equals(item, default(T)))
                            {
                                list.Add(item);
                            }
                        }
                    }

                    return list;
                }
            }
        }

        public T ExecuteScalarWithCallbackEntity<T>(CommandType commandType,
          string commandText, Func<SqlDataReader, T> callback, SqlParameter[] parameters = null) where T : class, new()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(commandText, connection) { CommandType = commandType })
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    command.CommandTimeout = 0;

                    var reader = command.ExecuteReader();
                    var entity = new T();

                    using (reader)
                    {
                        while (reader.Read())
                        {
                            entity = callback(reader);
                        }
                    }

                    return entity;
                }
            }
        }

        public object ExecuteScalar(CommandType commandType, string commandText, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(commandText, connection) { CommandType = commandType })
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    command.CommandTimeout = 0;

                    var result = command.ExecuteScalar();
                    return result;
                }
            }
        }

        public void ExecuteNonQuery(CommandType commandType, string commandText, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(commandText, connection) { CommandType = commandType })
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    command.CommandTimeout = 0;

                    command.ExecuteNonQuery();
                }
            }
        }

        private readonly string _connectionString;
    }
}
