namespace OOP_Polymorphism
{
    public class Ellipse : Geometry
    {
        protected double RadiusA { get; set; }
        protected double RadiusB { get; set; }
        public Ellipse()
        {
            RadiusA = 2.35;
            RadiusB = 4.9;
            ShapeName = "Ellipse";
        }
        public Ellipse(double radiusA, double radiusB)
        {
            RadiusA = radiusA;
            RadiusB = radiusB;
            ShapeName = "Ellipse";
        }
        public override double Area()
        {
            return RadiusA * RadiusB * Math.PI;
        }
    }
}
