using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WWLinePainting.Models.Account
{
    public class AccountDataContext : IdentityDbContext<ApplicationUser>
    {
        public AccountDataContext()
        {
            Database.EnsureCreated();
        }
    }
}
