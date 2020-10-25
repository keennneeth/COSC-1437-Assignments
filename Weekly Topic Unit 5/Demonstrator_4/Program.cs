using System;
using AbstractClassLibrary;

namespace Demonstrator_4
/*
 * Kenneth Rodriguez
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kenneth Rodriguez Demonstrator_4");
            Console.WriteLine();

            AbstractGeometricShape myGeometricShape;

            myGeometricShape = new Triangle() { SideLength = 123.456 };
            TellAboutTheShape(myGeometricShape);

            Console.WriteLine();

            myGeometricShape = new Square() { SideLength = 321.654 };
            TellAboutTheShape(myGeometricShape);

            Console.WriteLine();

            myGeometricShape = new Pentagon() { SideLength = 1.123 };
            TellAboutTheShape(myGeometricShape);



            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }

        static void TellAboutTheShape(AbstractGeometricShape thisShape)
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
