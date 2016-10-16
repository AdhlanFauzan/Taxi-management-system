using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using DAL.Abstarction.Repositories;
using DAL.Names;
using DAL.Parsers;
using Entities.Concrete;

namespace DAL.Concrete.Repositories
{
    public class UserRepository : BaseRepository.BaseRepository, IUserRepository
    {
        public UserRepository(string connectionString) : base(connectionString)
        {
        }

        public User GetUserByLogin(string login, string password)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter(ParameterNames.login,login),
                new SqlParameter(ParameterNames.password,GetMd5HashPassword(password))
            };

            return SqlWrapper.ExecuteScalarWithCallbackEntity(CommandType.StoredProcedure,
                StoredProcedureNames.spGetUserByLogin, UserParser.Instance.MakeBuildingResult, parameters);
        }

        private static string GetMd5HashPassword(string password)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(password));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
