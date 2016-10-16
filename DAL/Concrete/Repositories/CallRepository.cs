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
    internal class CallRepository : BaseRepository.BaseRepository, ICallRepository
    {
        public CallRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<Call> GetAll()
        {
            return SqlWrapper.ExecuteReaderWithCallback(CommandType.StoredProcedure, StoredProcedureNames.spGetAllCalls,
                CallParser.Instance.MakeBuildingResult);
        }

        public void Insert(Call call)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ColumnNames.CarId, call.CarId),
                new SqlParameter(ColumnNames.DeparturePlace, call.DeparturePlace),
                new SqlParameter(ColumnNames.ArrivalPlace, call.ArrivalPlace),
                new SqlParameter(ColumnNames.Distance, call.Distance),
            };

            SqlWrapper.ExecuteNonQuery(CommandType.StoredProcedure, StoredProcedureNames.spInsertCall, parameters);
        }

        public void Delete(int id)
        {
            SqlParameter[] parameter =
            {
                new SqlParameter(ParameterNames.callId, id)
            };

            SqlWrapper.ExecuteNonQuery(CommandType.StoredProcedure, StoredProcedureNames.spDeleteCall, parameter);
        }

        public IEnumerable<Call> GetCallsByCarId(int carId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ParameterNames.carId, carId)
            };

            return SqlWrapper.ExecuteReaderWithCallback(CommandType.StoredProcedure,
                StoredProcedureNames.spGetCallsByCarId,
                CallParser.Instance.MakeBuildingResult, parameters);
        }

        public string DayInfo(string date)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ParameterNames.date, date),
            };

            object o = SqlWrapper.ExecuteScalar(CommandType.StoredProcedure, StoredProcedureNames.spDayInfo, parameters);

            return o is DBNull ? "0 0 0 0" : (string) o;
        }
    }
}
