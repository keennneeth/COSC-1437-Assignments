using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  /*
  * Kenneth Rodriguez
  */

namespace CustomerAndInventory_Tests
{
    [TestClass]
    public class OrderItem_Tests
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

        public void Check_Proper_Assignement_Of_The_Order_ID()
        {
            //assign
            var AssignedOrderID = 321;
            var customer = new CustomerAndInventory.Customer();

            //action
            customer.ID = AssignedOrderID;

            //assert
            Assert.AreEqual(AssignedOrderID, customer.ID);
        }
        [TestMethod]

        public void Check_Proper_Assignement_Of_The_Product_ID()
        {
            //assign
            var AssignedProductID = 4444444;
            var customer = new CustomerAndInventory.Customer();

            //action
            customer.ID = AssignedProductID;

            //assert
            Assert.AreEqual(AssignedProductID, customer.ID);
        }
    }
}
