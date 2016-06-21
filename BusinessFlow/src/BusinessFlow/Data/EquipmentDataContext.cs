using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessFlow.Data
{
    public class EquipmentDataContext : DbContext
    {
        // Controller will use
        public DbSet<Equipment> EquipmentList { get; set; }

        public EquipmentDataContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = @"Data Source=(localdb)\v11.0;Initial Catalog=BusinessFlow;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ForSqlServerUseIdentityColumns();
        }
    }
}
