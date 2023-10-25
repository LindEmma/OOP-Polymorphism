using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Elipse : Geometry
    {
        protected double RadiusA{get;set;}
        protected double RadiusB { get; set; }
        public Elipse()
        {
            RadiusA = 2;
            RadiusB = 4;
            Shape = "Ellipse";
        }
        public override double Area()
        {
            return RadiusA * RadiusB * Math.PI;
        }

    }
}
