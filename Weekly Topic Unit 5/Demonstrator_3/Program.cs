using System;
using GeometricShapes;

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

            IGeometricShapes myGeometricShapes;

            myGeometricShapes = new Triangle() { SideLength = 123.456 };
            TellAboutTheShape(myGeometricShapes);

            Console.WriteLine();

            myGeometricShapes = new Square() { SideLength = 321.654 };
            TellAboutTheShape(myGeometricShapes);

            Console.WriteLine();

            myGeometricShapes = new Pentagon() { SideLength = 1.123 };
            TellAboutTheShape(myGeometricShapes);
    
          

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
