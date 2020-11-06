using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace MyTestForQueues
{
    [TestClass]
    public class GenericQueueIntegerTest
    {

        [TestMethod]
        public void Create_Queue_And_Verify_Empty()
        {
            // assign
            var myQueue = new Queue<int>();

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
            var myQueue = new Queue<int>();

            // act
            myQueue.Enqueue(111);
            myQueue.Enqueue(222);
            myQueue.Enqueue(333);
            myQueue.Enqueue(444);
            myQueue.Enqueue(555);

            // assert
            myQueue.Count.ShouldBe(5);

            var scratch1 = myQueue.Peek();
            scratch1.ShouldBe(111);

            var scratch2 = myQueue.Dequeue();
            scratch2.ShouldBe(111);

            var scratch3 = myQueue.Dequeue();
            scratch3.ShouldBe(222);
             
            myQueue.Dequeue();
            myQueue.Dequeue();

            myQueue.Count.ShouldBe(1);

            var scratch4 = myQueue.Dequeue();
            scratch4.ShouldBe(555);

            myQueue.Count.ShouldBe(0);
        }

        [TestMethod]
        public void ReturnAnArray()
        {
            // assign
            var myQueue = new Queue<int>();

            // act
            myQueue.Enqueue(111);
            myQueue.Enqueue(222);
            myQueue.Enqueue(333);
            myQueue.Enqueue(444);
            myQueue.Enqueue(555);

            // assert
            myQueue.Count.ShouldBe(5);

            var scratch1 = myQueue.Peek();
            scratch1.ShouldBe(111);

            var scratch2 = myQueue.Dequeue();
            scratch2.ShouldBe(111);

            var scratch3 = myQueue.Dequeue();
            scratch3.ShouldBe(222);

            myQueue.Dequeue();
            myQueue.Dequeue();

            myQueue.Count.ShouldBe(1);

            var scratch4 = myQueue.Dequeue();
            scratch4.ShouldBe(555);

            myQueue.Count.ShouldBe(0);
        }

    }
}
