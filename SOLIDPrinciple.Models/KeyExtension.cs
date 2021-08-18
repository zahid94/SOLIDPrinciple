using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Models
{
    public class KeyExtension
    {
        [Key]
        public int Id { get; set; }
        public int RequesterId { get; set; }
        public int KeyRequestId { get; set; }
        public DateTime ExtenTime { get; set; }
    }
}
