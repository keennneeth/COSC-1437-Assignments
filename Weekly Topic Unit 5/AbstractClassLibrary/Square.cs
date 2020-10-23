using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassLibrary
{
    public class Square : AbstractGeometricShape
    {
        public Square()
        {
            NumberOfSides = 4;
        }

        public override double Area() => SideLength * SideLength;

        public override string Description()
        {
            return $"This square is a {NumberOfSides}-sided geometric shape. Each side is {SideLength} amd the area is {Area()}";
        }
    }
}
