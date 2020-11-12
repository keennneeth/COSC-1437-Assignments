using System;
using System.Text.RegularExpressions;
using BinaryTreeImplementation;

/*
 * Kenneth Rodriguez
 */

namespace RandomNumberDemo
{
    class RandomNumberDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kenneth Rodriguez - Assignment 8");

            Console.WriteLine("\nAs Loaded...");

       

            var number = new BinaryTree<int>();

            var RandomNumber = new Random();

            for (var loopnum = 0; loopnum < 10; loopnum++)

            {
                var NextNumber = RandomNumber.Next(0, 100);
                number.Add(NextNumber);
                Console.Write($" {NextNumber} ");
            }
            Console.Write("\n");

            Console.WriteLine("\nAs Retrieved...");
     

            foreach (var word in number)

            {
            Console.Write($" {word} ");
            }
            Console.Write("\n");


        }
    }
}
