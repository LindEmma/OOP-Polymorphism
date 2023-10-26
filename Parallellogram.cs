namespace OOP_Polymorphism
{
    public class Parallellogram : Geometry
    {
        protected double SideA { get; set; }
        protected double SideB { get; set; }
        public Parallellogram()
        {
            SideA = 6.55;
            SideB = 3.1;
            ShapeName = "Parallellogram";
        }
        public Parallellogram (double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
            ShapeName = "Parallellogram";
        }
        public override double Area()
        {
            return SideA * SideB;
        }
    }
}
