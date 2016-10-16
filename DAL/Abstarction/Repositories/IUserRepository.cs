using Entities.Concrete;

namespace DAL.Abstarction.Repositories
{
    public interface IUserRepository
    {
        User GetUserByLogin(string login, string password);
    }
}
