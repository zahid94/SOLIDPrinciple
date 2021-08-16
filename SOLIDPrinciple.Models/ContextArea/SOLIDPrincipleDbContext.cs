using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Models.ContextArea
{
    public class SOLIDPrincipleDbContext:DbContext
    {
        public SOLIDPrincipleDbContext():base("")
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
