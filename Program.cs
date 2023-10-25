using static System.Net.Mime.MediaTypeNames;
using System.Numerics;
using System.Threading;

namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Geometry> shapes = new List<Geometry>();

            shapes.Add(new Square());
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Elipse());
            shapes.Add(new Parallellogram());

            foreach (Geometry g in shapes)
            {
                Console.WriteLine(g.Shape + " area is: " + Math.Round(g.Area(),2)+"\n");
            }
        }
    }
}