using System;
using System.Collections.Generic;
using System.Text;
using GeometricShapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;


/*
 * Kenneth Rodriguez
 */

namespace GeometricShapes_Tests
{
    [TestClass]
    public class Square_Tests
    {
        [TestMethod]
        public void Verify_That_There_Are_4_Sides()
        {
            //arrange
            Square square = new Square();

            //act

            //Assert
            square.NumberOfSides.ShouldBe(4);
        }

        [TestMethod]
        public void Verify_The_SideLength_May_Be_Set_And_Retrieved()
        {
            //Arrange
            Square square = new Square();
            double expectedValue = 1.2d;

            //Act
            square.SideLength = expectedValue;

            //assert
            square.SideLength.ShouldBe(expectedValue);

        }

        [TestMethod]
        public void Verify_The_Permeter_May_Be_Set_And_Retrieved()
        {
            //Arrange
            Square square = new Square();
            double sideLength = 3.4d;
            double expectedvalue = 13.6d;

            //Act
            square.SideLength = sideLength;

            //Assert

            square.Perimeter().ShouldBe(expectedvalue);

        }
        [TestMethod] 
        public void Verify_The_Area_is_Calculated_Accurately()
        {
            //Arrange
            Square square = new Square();
            double sideLength = 5.6d;
            double expectedArea = 31.359999999999996d;

            //Act
            square.SideLength = sideLength;

            //Assert
            square.Area().ShouldBe(expectedArea);
        }
        [TestMethod]
        public void Verify_TotalMeasureOfAllAngles_Is_Calculated_Accurately()
        {
            // Arrange
            Square square = new Square();

            // Act
            var x = square.TotalMeasureOfAllAngles();

            // Assert
            square.TotalMeasureOfAllAngles().ShouldBe(360);
        }

    }
}
