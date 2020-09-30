using System;

/*
 * ProfReynolds - your name here
 */

namespace CustomerAndInventory
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; } // ProfReynolds - good
        public string Payment { get; set; } // ProfReynolds - good
        public string Email { get; set; } // ProfReynolds - good

        public string FullName()
        {
            /*
             * ProfReynolds
             * you should implement this method. This is only the placeholder.
             * return the Full Name - the first name, a space, and the last name
             */
            return " ";
        }
        public bool ValidateName()
        {
            /*
             * ProfReynolds
             * the intermediate step using the variable 'v' is unnecessary
             * hint: is the name valid if the length is <1?
             * hint: should false always be returned? (maybe FirstNameIsValid && LastNameIsValid)
             */
            bool v = FirstName.Length < 1;
            bool FirstNameIsValid = v;
            bool LastNameIsValid = LastName.Length < 1;

            return false;
        }
    }
}
