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
        public SOLIDPrincipleDbContext():base("Db")
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<KeyExtension> KeyExtensions { get; set; }
        public DbSet<KeyReconcile> KeyReconciles { get; set; }
        public DbSet<KeyRequest> KeyRequests { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<LeaveOfAbsence> LeaveOfAbsences { get; set; }
    }
}
