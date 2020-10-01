using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerAndInventory_Tests
{
    [TestClass]
    public class Order_Tests
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
        public void Check_Proper_Assignment_Of_The_Customer_ID()
        {
            //assign
            var customer = new CustomerAndInventory.Customer();

            //action
            customer.ID = 1234;

            //assert
            Assert.AreEqual(1234, customer.ID);
        }

    }
}


