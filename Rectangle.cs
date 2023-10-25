using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Rectangle : Geometry

    {
        protected double SideA { get; set; }
        protected double SideB { get; set; }
        public Rectangle()
        {
            SideA = 5;
            SideB = 4;
            Shape = "Rectangle";
        }
        public override double Area()
        {
            return SideA * SideB;
        }
    }
}
