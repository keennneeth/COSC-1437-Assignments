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
    public class Triangle_Tests
    {
        [TestMethod]
        public void Verify_That_NumberOfSides_Is_3()
        {
            //Arrange
            Triangle triangle = new Triangle();

            //Act

            //Assert
            triangle.NumberOfSides.ShouldBe(3);

        }
        [TestMethod]
        public void Verify_The_SideLength_May_Be_Set_And_Retrieved()
        {
            //Arrange
            Triangle triangle = new Triangle();
            double expectedValue = 1.2d;

            //Act
            triangle.SideLength = expectedValue;

            //Assert
            triangle.SideLength.ShouldBe(expectedValue);
        }
        [TestMethod]
        public void Verify_The_Perimeter_Can_Be_Set_And_Retrieved()
        {
            //Arrange
            Triangle triangle = new Triangle();
            double sideLength = 3.4d;
            double expectedValue = 10.2d;

            //Act
            triangle.SideLength = sideLength;

            //Assert
            triangle.Perimeter().ShouldBe(expectedValue);
        }
        [TestMethod]
        public void Verify_That_The_Area_Is_Calculated_Accurately()
        {
            //Arrange
            Triangle triangle = new Triangle();
            double sideLength = 5.6d;
            double expectedAreaMinAcceptable = 13.579d;
            double expectedAreaMaxAcceptable = 13.581d;

            //Act
            triangle.SideLength = sideLength;

            //Assert
            triangle.Area().ShouldBeInRange(expectedAreaMinAcceptable, expectedAreaMaxAcceptable);
        }
    }
}
