using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace WorkFlowManager.Models
{
    public class PartDataContext : DbContext
    {
        public DbSet<Part> Parts { get; set; }
     
        // Constructor     
        public PartDataContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = @"Server=tcp:bitrivet.database.windows.net,1433;Data Source=bitrivet.database.windows.net;Initial Catalog=WWLPC;Persist Security Info=False;User ID=BRSADMIN;Password=UPJcpa409$;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ForSqlServerUseIdentityColumns();
        }


    }

}
