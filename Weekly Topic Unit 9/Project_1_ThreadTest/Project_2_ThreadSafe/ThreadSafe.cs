using System;
using System.Threading;

namespace Project_2_ThreadSafe


    /*
     * Kenneth Rodriguez
     */


{
    class ThreadSafe
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Kenneth Rodriguez");
            Console.WriteLine("Weekly Topic Unit 9");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1) Demonstrate the ThreadSafeTest");
                Console.WriteLine("X) Exit");
                Console.Write("Select Demonstration: ");

                var keyPressed = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();

                switch (keyPressed)
                {
                    case 'X':
                    case 'x':
                        return;

                    case '1': ThreadSafeTest(); break;
                }
                Console.WriteLine();
            }
        }

        static bool _done;
        static readonly object Locker = new object();

        static int ThreadSafeTest()
        {


            // This step is important because without it then the program wouldn't know when to start
            // when you click '1' to select a demonstrator nothing will happen because
            // it never started, it will just be blank everytime and will return you to the
            // 'select a demonstrator' option again.



            _done = false;
            new Thread(Go).Start();
            Go();

            return 0;
        }

        static void Go()
        {
            lock (Locker)
            {
                if (!_done)
                {
                    Thread.Sleep(10);
                    _done = true;
                    Console.WriteLine("Method 'Go' has been reached, _done is now true");
                }
            }
        }
    }


}
