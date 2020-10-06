using System;
using System.Collections.Generic;
using System.Text;


/*
* Kenneth Rodriguez
*/

namespace GeometricShapes
{
    public class Triangle : IGeometricShapes
    {
        public int NumberOfSides 

        {
            get
            {
            return 3;
            }
}
        private double _SideLength;
        public double SideLength
        {
            get
            {
                return _SideLength;
            }
            set
            {
                _SideLength = value;
            }
        }


        public double Perimeter()

        {
            return 3 * _SideLength;
        }
        public double Area()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow (_SideLength, 2);
        }
        public int TotalMeasureOfAllAngles()
        {
            return 180;
        }
    }
}
