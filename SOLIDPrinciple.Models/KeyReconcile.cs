using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Models
{
    public class KeyReconcile
    {
        public int Id { get; set; }
        public int RequesterId { get; set; }
        public int KeyRequestId { get; set; }
        public DateTime ReconcilationDate { get; set; }
    }
}
