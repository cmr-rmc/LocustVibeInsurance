using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Claims;
using LocustVibeInsurance.Models;
using Microsoft.EntityFrameworkCore;

namespace LocustVibeInsurance.Data
{
    public class LocustVibeInsuranceContext : DbContext
    {
        public LocustVibeInsuranceContext(DbContextOptions<LocustVibeInsuranceContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Models.Claim> Claims { get; set; }
        public DbSet<InsuranceType> InsuranceType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Models.Claim>().ToTable("Claims");
            modelBuilder.Entity<InsuranceType>().ToTable("InsuranceType");
        }

    }
}
