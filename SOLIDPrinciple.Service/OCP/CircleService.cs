using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.OCP
{
    public class CircleService : ShapeService
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius*Radius*Math.PI;
        }
    }
}
