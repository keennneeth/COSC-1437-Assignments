using System;

namespace CustomerAndInventory
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Payment { get; set; }
        public string Email { get; set; }

        public string FullName()
        {
            return " ";
        }
        public bool ValidateName()
        {

            bool v = FirstName.Length < 1;
            bool FirstNameIsValid = v;
            bool LastNameIsValid = LastName.Length < 1;

            return false;
        }
    }
}
