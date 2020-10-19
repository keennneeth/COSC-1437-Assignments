using GeometricShapes;
using System;

namespace Demonstrator_1


    /*
     * Kenneth Rodriguez
     */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kenneth Rodriguez Demonstrator_1");
            Console.WriteLine();

            var triangle = new Triangle();
            triangle.SideLength = 123.456;
            Console.WriteLine(triangle.Description());
            Console.WriteLine($"Number of Sides = {triangle.NumberOfSides}");
            Console.WriteLine($"Length of the Sides = {triangle.SideLength}");
            Console.WriteLine($"Perimeter of the shape = {triangle.Perimeter()}");
            Console.WriteLine($"Area of the shape = {triangle.Area()}");

            Console.WriteLine();

            var square = new Square();
            square.SideLength = 321.654;
            Console.WriteLine(square.Description());
            Console.WriteLine($"Number of Sides = {square.NumberOfSides}");
            Console.WriteLine($"Length of the Sides = {square.SideLength}");
            Console.WriteLine($"Perimeter of the shape = {square.Perimeter()}");
            Console.WriteLine($"Area of the shape = {square.Area()}");

            Console.WriteLine();

            var pentagon = new Pentagon();
            Console.WriteLine(pentagon.Description());
            pentagon.SideLength = 1.123;
            Console.WriteLine($"Number of Sides = {pentagon.NumberOfSides}");
            Console.WriteLine($"Length of the Sides = {pentagon.SideLength}");
            Console.WriteLine($"Perimeter of the shape = {pentagon.Perimeter()}");
            Console.WriteLine($"Area of the shape = {pentagon.Area()}");

            Console.WriteLine();
            Console.Write("Press any key to continue");
            Console.ReadKey();

        }
    }
}
