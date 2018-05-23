using FuelManApi.Service.Core.Repositories.Interfaces;
using System.Linq;

namespace FuelManApi.Service.Core.Repositories
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(FuelManContext context) : base(context)
        {

        }

        public User LoginDetailsMatched(string email, string password)
        {
            return UserContext.Users.SingleOrDefault(usr => usr.Email == email && usr.Password == password);
        }

        public FuelManContext UserContext => Context as FuelManContext;
    }
}
