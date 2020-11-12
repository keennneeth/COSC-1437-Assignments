using System;
using System.Text.RegularExpressions;
using BinaryTreeImplementation;

/*
 * ProfReynolds
 */

namespace WordSorterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<string>();

            do
            {
                // read the line from the user
                Console.Write("> ");
                var consoleInput = Console.ReadLine();
                if (consoleInput.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
                    break;


                // split the line into words (on space)

                var words = Regex.Split (consoleInput," ");

                // add each word to the tree
                foreach (var word in words)
                {
                    tree.Add(word);
                }

                // print the number of words
                Console.WriteLine($"{tree.Count} words");

                // and print each word using the default (in-order) enumerator
                foreach (string word in tree)
                {
                    Console.Write($"^{word}^");
                }

                Console.WriteLine();

                tree.Clear();
            } while (true);
        }
    }
}