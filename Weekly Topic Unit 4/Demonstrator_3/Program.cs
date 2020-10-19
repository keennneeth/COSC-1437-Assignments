using GeometricShapes;
using System;

namespace Demonstrator_3
    /*
     * Kenneth Rodriguez
     */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kenneth Rodriguez Demonstrator_3");
            Console.WriteLine();

            var triangle = new Triangle();
            triangle.SideLength = 123.456;
            TellAboutTheShape(triangle);

            Console.WriteLine();

            var square = new Square()
            {
                SideLength = 321.654
            };
            TellAboutTheShape(square);

            Console.WriteLine();

            TellAboutTheShape(new Pentagon()
            {
                SideLength = 1.123
            });

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }

        static void TellAboutTheShape(IGeometricShapes thisShape)
        {
            Console.WriteLine($"This Object is a {thisShape.GetType()}");
            Console.WriteLine(thisShape.Description());
            Console.WriteLine("Number of Sides = {thisShape.NumberOfSides}");
            Console.WriteLine($"Length of the Sides = {thisShape.SideLength}");
            Console.WriteLine($"Perimeter of the shape = {thisShape.Perimeter()}");
            Console.WriteLine($"Area of the shape = {thisShape.Area()}");
        

        }
    }
}
