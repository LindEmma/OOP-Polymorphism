namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I chose to make a list (shapes) and make
            // new objects directly inside of it
            List<Geometry> shapes = new List<Geometry>();

            shapes.Add(new Square());
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Ellipse());
            shapes.Add(new Parallellogram());

            // Loops through all objects in shapes
            // outputs their ShapeName + return value in method Area.
            // Also rounds up the values to two decimals in the output.
            foreach (Geometry g in shapes)
            {
                Console.WriteLine(g.ShapeName + " area is: " + Math.Round(g.Area(), 2) + "\n");
            }
        }
    }
}