using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Models
{
    public class LeaveOfAbsence
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Day { get; set; }
    }
}
