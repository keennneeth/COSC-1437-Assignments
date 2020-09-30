using System;
using System.Collections.Generic;
using System.Text;
using CustomerAndInventory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * ProfReynolds - your name here
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

        #region other tests required of the student

        [TestMethod]
        public void Verify_The_First_Name_Can_Be_Assigned()
        {
            // assign
            var customer = new CustomerAndInventory.Customer();

            // action
            customer.FirstName = "John";

            // assert
            // for you to do
        }

        public void Verify_The_Last_Name_Can_Be_Assigned()
        {
            // assign
            var customer = new CustomerAndInventory.Customer();

            // action
            // for you to do

            // assert
            // for you to do
        }

        public void Verify_The_Full_Name_Represents_The_First_And_Last_Names()
        {
            // for you to do
        }

        public void Verify_The_ValidateName_Returns_True_If_Both_Names_Have_2_Or_More_Characters_Each()
        {
            // for you to do
        }

        #endregion
    }
}
