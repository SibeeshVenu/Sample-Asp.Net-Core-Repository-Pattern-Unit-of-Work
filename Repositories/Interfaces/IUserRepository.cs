using FuelManApi.Contracts.Models.Auth;

namespace FuelManApi.Service.Core.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User LoginDetailsMatched(string email, string password);
    }
}
