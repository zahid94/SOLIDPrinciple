using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.OCP
{
    public class SquareService : ShapeService
    {
        public double length { get; set; }
        public override double Area()
        {
            return length * length;
        }
     }
}
