using System;
using System.Collections;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace MyTestForQueues
{
    [TestClass]
    public class PlainOleQueueTests
    {

        [TestMethod]
        public void Create_Queue_And_Verify_Empty()
        {
            // assign
            var myQueue = new Queue();

            // act

            // assert
            myQueue.Count.ShouldBe(0);

            Should.Throw<InvalidOperationException>(
                () => myQueue.Dequeue()
                );

            Should.Throw<InvalidOperationException>(
                () => myQueue.Peek()
            );
        }

        [TestMethod]
        public void Enqueue_And_Dequeue_Values()
        {
            // assign
            var myQueue = new Queue();

            // act
            myQueue.Enqueue(123);
            myQueue.Enqueue("COSC-1437");
            myQueue.Enqueue(new Object());
            myQueue.Enqueue("COSC-1437");
            myQueue.Enqueue(3.14);

            // assert
            myQueue.Count.ShouldBe(5);

            var scratch1 = myQueue.Peek();
            scratch1.ShouldBe(123);

            var scratch2 = myQueue.Dequeue();
            scratch2.ShouldBe(123);

            var scratch3 = myQueue.Dequeue();
            scratch3.ShouldBe("COSC-1437");

            myQueue.Dequeue();
            myQueue.Dequeue();

            myQueue.Count.ShouldBe(1);

            var scratch4 = myQueue.Dequeue();
            scratch4.ShouldBe(3.14);

            myQueue.Count.ShouldBe(0);
        }

        [TestMethod]
        public void ReturnAnArray()
        {
            // assign
            var myQueue = new Queue();

            // act
            myQueue.Enqueue(123);
            myQueue.Enqueue("COSC-1437");
            myQueue.Enqueue(new Object());
            myQueue.Enqueue("Kenneth Rodriguez");
            myQueue.Enqueue(3.14);

            // assert
            myQueue.Count.ShouldBe(5);

            var myQueueArray = myQueue.ToArray();
            myQueueArray.ShouldBeOfType<object[]>();
            myQueueArray[0].ShouldBe(123);
            myQueueArray[1].ShouldBe("COSC-1437");
            myQueueArray[2].ShouldBeOfType<object>();
            myQueueArray[3].ShouldBe("Kenneth Rodriguez");
            myQueueArray[4].ShouldBe(3.14);
        }

    }
}
