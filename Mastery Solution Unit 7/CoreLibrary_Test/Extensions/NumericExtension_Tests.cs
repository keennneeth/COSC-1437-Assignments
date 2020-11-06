using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using CoreLibrary;

namespace CoreLibrary_Test.Extensions
{
    [TestClass]
   public class NumericExtension_Tests
    {
        [DataTestMethod]
        [DataRow("12", 999, 12)]
        [DataRow("12.12", 999, 12)]
        [DataRow("0", 999, 0)]
        [DataRow("-1", 999, -1)]
        [DataRow(null, 999, 999)]
        [DataRow("test", 999, 999)]
        [DataRow("123.45.67", 999, 999)]

        public void ToIntTest(string testValue, int defaultValue, int expectedResult)
        {
            // Arrange

            // Act
            int intResult = testValue.ToInt(defaultValue);

            // Assert
            intResult.ShouldBe(expectedResult);
        }
    }
}

