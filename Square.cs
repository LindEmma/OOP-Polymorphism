namespace OOP_Polymorphism
{
    // child class Square inherits parent class Geometry 
    public class Square : Geometry
    {
        // Unique property for Square
        protected double Side { get; set; }

        // Default constructor with set values for Side and ShapeName
        public Square()
        {
            Side = 8.535;
            ShapeName = "Square";
        }
        // Constructor with a parameter,
        // different squares can be created in the Main method (optional)
        public Square(double side)
        {
            Side = side;
            ShapeName = "Square";
        }
        // Overrides method Area with the formula for calculating the area of a square. Returns a double.
        public override double Area()
        {
            return Math.Pow(Side, 2);
        }
    }
}
// The code is written in basically the same way for all child classes