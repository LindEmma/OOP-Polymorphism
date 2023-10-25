using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Circle:Geometry
    {
        protected double Radius { get; set; }

        public Circle()
        {
            Radius = 4;
            Shape = "Circle";
        }
        public override double Area()
        {
            return Radius * Radius;
        }
    }
}
