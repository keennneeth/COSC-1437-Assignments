using CoreLibrary.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace CoreLibrary_Tests.Extensions
{
    [TestClass]
    public class StringExtensions_Tests
    {
        [TestMethod]
        public void IsNullOrEmpty_Test()
        {
            // Arrange
            string testCondition1 = string.Empty;
            string testCondition2 = null;
            string testCondition3 = "ProfReynolds";
            string testCondition4 = "     ";

            // Act
            var actualResult1 = testCondition1.IsNullOrEmpty();
            var actualResult2 = testCondition2.IsNullOrEmpty();
            var actualResult3 = testCondition3.IsNullOrEmpty();
            var actualResult4 = testCondition4.IsNullOrEmpty();

            // Assert
            actualResult1.ShouldBeTrue();
            actualResult2.ShouldBeTrue();
            actualResult3.ShouldBeFalse();
            actualResult4.ShouldBeFalse();
        }
    }
}
