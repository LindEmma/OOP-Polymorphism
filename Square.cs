using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Square:Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 5;
            Shape = "Square";
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
}
