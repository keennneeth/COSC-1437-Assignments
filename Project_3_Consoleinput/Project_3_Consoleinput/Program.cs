using System;

namespace Project_3_Consoleinput
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Kenneth";
            string lastname = "Rodriguez";

            Console.WriteLine("Name: " + firstname + " " + lastname);

            Console.WriteLine("Please enter a new first name: ");
            firstname = Console.ReadLine();

            Console.WriteLine("Please enter a new last name: ");
            lastname = Console.ReadLine();

            Console.WriteLine("New Name: " + firstname + " " + lastname);

            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
    }
}
