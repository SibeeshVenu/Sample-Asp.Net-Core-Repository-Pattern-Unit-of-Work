using System;
using FuelManApi.Contracts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FuelManApi.Service.Core
{
    public class FuelManContext : DbContext, IFuelManContext
    {
        public FuelManContext() : base(GetDbContextOptions())
        {

        }

        public DbSet<User> Users { get; set; }
        

        private static DbContextOptions GetDbContextOptions()
        {
            return new DbContextOptionsBuilder().UseSqlServer(GetConnectionString()).Options;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) { optionsBuilder.UseSqlServer(GetConnectionString()); }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.RemovePluralizingTableNameConvention();
        }

        /// <summary>
        /// Reads the connection string from the appsettings file,
        /// </summary>
        /// <returns>The connection string.</returns>
        private static string GetConnectionString()
        {
            var environmentName = Environment.GetEnvironmentVariable("Hosting:Environment");
            var basePath = AppContext.BaseDirectory;
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json", true)
                .AddEnvironmentVariables();

            var config = builder.Build();
            var connstr = config.GetConnectionString("DefaultConnection");

            if (string.IsNullOrWhiteSpace(connstr))
            {
                throw new InvalidOperationException(
                    "Could not find a connection string named '(DefaultConnection)'.");
            }
            else
            {
                return connstr;
            }
        }
    }
}
