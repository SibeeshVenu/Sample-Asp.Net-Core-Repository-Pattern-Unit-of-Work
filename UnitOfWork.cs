using FuelManApi.Service.Core.Repositories;
using FuelManApi.Service.Core.Repositories.Interfaces;

namespace FuelManApi.Service.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// The database context.
        /// </summary>
        private readonly FuelManContext _context;

        /// <summary>
        /// The users repository.
        /// </summary>
        public IUserRepository Users { get; private set; }

        public UnitOfWork(FuelManContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();

        }
        /// <summary>
        /// Completes the transaction (Save Change)
        /// </summary>
        /// <returns>The number of rows effected</returns>
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
