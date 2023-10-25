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
        public override double Area()
        {
            return SideA * SideB;
        }
    }
}
