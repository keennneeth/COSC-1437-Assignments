using System;
using System.Collections.Generic;
using System.Text;
/*
 * Kenneth Rodriguez
 */

namespace GeometricShapes
{
   public interface IGeometricShapes
    {
        int NumberOfSides { get; }
        double SideLength { get; set; }
        double Perimeter();
        double Area();
        int TotalMeasureOfAllAngles();
    }
}
