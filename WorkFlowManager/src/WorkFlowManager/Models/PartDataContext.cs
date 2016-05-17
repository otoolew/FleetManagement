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


    }

}
