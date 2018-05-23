using System;
using FuelManApi.Service.Core.Repositories.Interfaces;

namespace FuelManApi.Service.Core
{
    /// <summary>
    /// Unit of work interface.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// The repository for the user model.
        /// </summary>
        IUserRepository Users { get; }
        int Complete();
    }
}
