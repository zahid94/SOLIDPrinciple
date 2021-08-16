using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.OCP
{
    public abstract class ShapeService
    {
        /// <summary>
        /// THIS ABSTRACT METHOD FOR DESIGN VARIATION TO USE AREA CALCULATION
        /// WHEN A METHOD NEED TO IMPLEMENT VARIATION IN DIFFERENT SITUATION THEN IT COL OPEN/CLOSE PRINCIPLES
        /// </summary>
        /// <returns></returns>
        public abstract double Area();
    }
}
