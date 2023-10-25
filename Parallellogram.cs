using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Parallellogram:Geometry
    {
        protected double SideA { get; set; }
        protected double SideB { get; set; }
        public Parallellogram()
        {
            SideA = 5;
            SideB = 4;
            Shape = "Parallellogram";
        }
        public override double Area()
        {
            return SideA * SideB;
        }
    }
}
