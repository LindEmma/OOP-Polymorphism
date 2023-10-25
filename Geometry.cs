namespace OOP_Polymorphism
{
    public abstract class Geometry
    {
        // Will be inherited 
        public string ShapeName { get; set; }

        // Abstract method that must be overrided in inheriting classes
        public abstract double Area();
    }
}
