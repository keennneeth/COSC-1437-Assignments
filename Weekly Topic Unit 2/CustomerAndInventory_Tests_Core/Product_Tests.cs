using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
* Kenneth Rodriguez
*/

namespace CustomerAndInventory_Tests
{
    [TestClass]
    public class Product_Tests
    {
        [TestMethod]
        public void Verify_The_ID_Is_Zero_When_Instantiated()
        {
            //assign
            var customer = new CustomerAndInventory.Customer();

            //action

            //assert
            Assert.AreEqual(expected: 0, actual: customer.ID);
        }
        [TestMethod]
        public void Verify_The_ID_Can_Be_Assigned()
        {
            //assign
            var assignedID = 1234;
            var customer = new CustomerAndInventory.Customer();
            //action
            customer.ID = assignedID;

            //assert
            Assert.AreEqual(expected: assignedID, actual: customer.ID);
        }
        [TestMethod]
        public void Product_Name()
        {
            //assign
            var ProductName = 00000000000;
            var customer = new CustomerAndInventory.Customer();

            //action
            customer.ID = ProductName;

            //Assert
            Assert.AreEqual(ProductName, customer.ID);

        }
        [TestMethod]
        public void Product_Description()
        {
            //assign
            var ProductDescription = 111111111;
            var customer = new CustomerAndInventory.Customer();

            //action
            customer.ID = ProductDescription;

            //Assert
            Assert.AreEqual(ProductDescription, customer.ID);

        }
    }
}
