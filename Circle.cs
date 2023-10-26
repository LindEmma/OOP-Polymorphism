namespace OOP_Polymorphism
{
    public class Circle : Geometry
    {
        protected double Radius { get; set; }

        public Circle()
        {
            Radius = 4;
            ShapeName = "Circle";
        }
        public Circle(double radius)
        {
            Radius = radius;
            ShapeName = "Circle";
        }
        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
