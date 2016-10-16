using DAL.Concrete.SQL;

namespace DAL.Concrete.BaseRepository
{
    public abstract class BaseRepository
    {
        protected BaseRepository(string connection)
        {
            SqlWrapper = new SqlCommandWrapper(connection);
        }

        public SqlCommandWrapper SqlWrapper { get; }
    }
}
