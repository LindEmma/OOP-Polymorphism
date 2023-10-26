namespace OOP_Polymorphism
{
    public class Rectangle : Geometry
    {
        protected double SideA { get; set; }
        protected double SideB { get; set; }
        public Rectangle()
        {
            SideA = 7;
            SideB = 4;
            ShapeName = "Rectangle";
        }
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
            ShapeName = "Rectangle";
        }
        public override double Area()
        {
            return SideA * SideB;
        }
    }
}
