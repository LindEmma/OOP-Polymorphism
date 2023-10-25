namespace OOP_Polymorphism
{
    // child class Square inherits parent class Geometry 
    public class Square : Geometry
    {
        // Unique property for Square
        public double Side { get; set; }

        // Constructor with set values for Side and ShapeName
        public Square()
        {
            Side = 8.535;
            ShapeName = "Square";
        }
        // Overrides method Area with the formula for calculating the area of a square. Returns a double.
        public override double Area()
        {
            return Math.Pow(Side, 2);
        }
    }
}
