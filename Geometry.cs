namespace OOP_Polymorphism
{
    // The parent class is abstract
    public abstract class Geometry
    {
        // Will be inherited by child classes 
        public string ShapeName { get; set; }

        // Abstract method that must be overrided in inheriting classes
        public abstract double Area();
    }
}
