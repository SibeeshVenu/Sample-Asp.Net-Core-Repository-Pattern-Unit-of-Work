using FuelManApi.Contracts.Models.Auth;
using Microsoft.EntityFrameworkCore;

namespace FuelManApi.Service.Core
{
    /// <summary>
    /// The Context interface.
    /// </summary>
    public interface IFuelManContext
    {
        DbSet<User> Users { get; set; }
    }
}
