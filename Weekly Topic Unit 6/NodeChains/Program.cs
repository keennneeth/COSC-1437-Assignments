using System;
using System.Diagnostics;

/*
 * ProfReynolds / Kenneth Rodriguez
 */

namespace NodeChains
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ProfReynolds / Kenneth Rodriguez NodeChains");
            Console.WriteLine();

            /*
             * creating the first node
             * since there is no second node, the Next property is null
             */
            var first = new Node { Value = 3 };
            //    +-----+------+
            //    |  3  | null +
            //    +-----+------+

            Debug.WriteLine($"\nnode #1: Value = {first.Value}, Next node = {first.Next}");


            /*
             * creating the second node
             * now the first node 'points' to the second node
             * but there is no third node, the Next property in the second node is null
             */
            var second = new Node { Value = 5 };
            first.Next = second;
            //    +-----+------+    +-----+------+
            //    |  3  | null +    |  5  | null +
            //    +-----+------+    +-----+------+
            Debug.WriteLine($"\nnode #1: Value = {first.Value}, Next node = {first.Next}");
            Debug.WriteLine($"node #2: Value = {second.Value}, Next node = {second.Next}");

            /*
             * similarly, the second node points to the third, but the third points nowhere
             */
            var third = new Node { Value = 7 };
            second.Next = third;
            //    +-----+------+    +-----+------+   +-----+------+
            //    |  3  |  *---+--->|  5  |  *---+-->|  7  | null +
            //    +-----+------+    +-----+------+   +-----+------+


            var fourth = new Node { Value = 4444 };
            third.Next = fourth;


            var fifth = new Node { Value = 55555 };
            fourth.Next = fifth;


            // a workingNode is a Node that is going to work by itself, meaning that it can write the next 5 numbers without
            // having to rewrite that code 5 times. It works by having a starting point, a max amount, and a counter
            // this will tell the working node how many numbers it will spit out and will stop when it hits that max amount.


            var r = new Random();
            var workingNode = fifth;
            for (var anotherNode = 0; anotherNode < 5; anotherNode++)
            {
                var newRandomValue = r.Next(100, 200);

                workingNode.Next = new Node();
                workingNode.Value = newRandomValue;

                workingNode = workingNode.Next;
            }



            // now iterate over each node and print the value
            Console.WriteLine("\n\nPrinting Iteratively");
            PrintListIteratively(first);


            // just for practice, print recursively
            Console.WriteLine("\n\nPrinting Recursively");
            PrintListRecursively(first);

            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private static void PrintListIteratively(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        private static void PrintListRecursively(Node node)
        {
            if (node == null) return;

            Console.WriteLine(node.Value);
            PrintListRecursively(node.Next);
        }

    }
}
