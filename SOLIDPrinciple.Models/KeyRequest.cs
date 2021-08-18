using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Models
{
    public class KeyRequest
    {
        public int Id { get; set; }
        public int RequesterId { get; set; }
        public int KeyId { get; set; }
        public int KeyType { get; set; }
    }
}
