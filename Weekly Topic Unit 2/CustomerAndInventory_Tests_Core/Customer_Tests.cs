using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading;
using CustomerAndInventory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * Kenneth Rodriguez
 */

namespace CustomerAndInventory_Tests
{
    [TestClass]
    public class Customer_Tests
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
        public void Verify_First_Name_Can_Be_Assigned()
        {
            //assign
            var customer = new CustomerAndInventory.Customer();

            //action
            customer.FirstName = "Kenneth";

            //assert
            Assert.AreEqual("Kenneth", customer.FirstName);
        }

        [TestMethod]

        public void Verify_Last_Name_Can_Be_Assigned()
        {
            //assign
            var customer = new CustomerAndInventory.Customer();

            //action
            customer.LastName = "Rodriguez";

            //assert
            Assert.AreEqual("Rodriguez", customer.LastName);
        }
        [TestMethod]
        public void Verify_The_ValidateName_Returns_True_If_Both_Names_Have_2_Or_More_Characters_Each()
        {
            //assign
            var customer = new CustomerAndInventory.Customer();

            //action
            customer.FirstName = "Kenneth";
            customer.LastName = "Rodriguez";

            //assert
            Assert.AreEqual(true, customer.ValidateName());
        }
        [TestMethod]
        public void Verify_The_Full_Name_Represents_The_First_And_Last_Name()
        {
            //assign
            var customer = new CustomerAndInventory.Customer();

            //action
            customer.FirstName = "Kenneth";
            customer.LastName = "Rodriguez";

            //assert
            Assert.AreEqual(true, customer.ValidateName());
        }
    }

}

