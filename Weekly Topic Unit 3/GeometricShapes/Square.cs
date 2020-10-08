using System;
using System.Collections.Generic;
using System.Text;
/*
 * Kenneth Rodriguez
 */

namespace GeometricShapes
{
    public class Square : IGeometricShapes
    {
        public int NumberOfSides
        {
            get { return 4;  }

        }
        public double SideLength { get; set; }

        public double Perimeter()
        {
            return 4 * SideLength;
        }
        public double Area()
        {
            return Math.Pow(SideLength, 2);
        }
        public int TotalMeasureOfAllAngles()
        {
             return 180; 
        }
    }
}
