using CoreLibrary.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System.Xml.Serialization;

/*
 * 
 * Kenneth Rodriguez
 */

namespace CoreLibrary_Tests.Extensions
{
    [TestClass]
    public class StringExtensions_Tests
    {
        [DataTestMethod]
        [DataRow("", true)]
        [DataRow(" ", false)]
        [DataRow(null, true)]
        [DataRow("Kenneth Rodriguez", false)]

        public void IsNullOrEmpty_Test(string testCondition, bool expectedResult)
        {

            // Arrange
            // no further arrangement required

            //Act
            var actualResult = testCondition.IsNullOrEmpty();

            //Assert
            actualResult.ShouldBe(expectedResult);
        }
        [DataTestMethod]
        [DataRow("", true)]
        [DataRow(" ", true)]
        [DataRow(null, true)]
        [DataRow("Kenneth Rodriguez", false)]
        public void IsNullOrWhiteSpace_Test(string testCondition, bool expectedResult)
        {
            // Arrange
            // no further arrangement required

            // Act
            var actualResult = testCondition.IsNullOrWhiteSpace();

            // Assert
            actualResult.ShouldBe(expectedResult);
        }



        [DataTestMethod]
        [DataRow("Kenneth Rodriguez", 8, "Kenneth ")]
        [DataRow("Kenneth Rodriguez", 99, "Kenneth Rodriguez")]
        [DataRow("Kenneth Rodriguez", 0, "")]
        [DataRow(null, 99, null)]
        public void Left_Test(string testCondition, int numCharacters, string expectedResults)

        {
            //Arrange

            //Act
            var actualResult = testCondition.Left(numCharacters);

            //Assert
            actualResult.ShouldBe(expectedResults);
        }

        [DataTestMethod]
        [DataRow("Kenneth Rodriguez", 8, "odriguez")]
        [DataRow("Kenneth Rodriguez", 99, "Kenneth Rodriguez")]
        [DataRow("Kenneth Rodriguez", 0, "")]
        [DataRow(null, 99, null)]
        public void Right_Test(string testCondition, int numCharacters, string expectedResults)

        {
            //Arrange

            //Act
            var actualResult = testCondition.Right(numCharacters);

            //Assert
            actualResult.ShouldBe(expectedResults);
        }
    }
}





          