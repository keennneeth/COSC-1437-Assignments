using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using MyGenericStack;
using System.Collections;

namespace UnitTestsForStacks
{
    [TestClass]
    public class MyGenericStackIntegerTest
    {

        [TestMethod]
        public void Create_Stack_And_Verify_Empty()
        {
            // assign
            var myStack = new MyStack<int>();

            // act

            // assert
            myStack.Count.ShouldBe(0);

            Should.Throw<InvalidOperationException>(
                () => myStack.Pop()
            );

            Should.Throw<InvalidOperationException>(
                () => myStack.Peek()
            );
        }
               
        [TestMethod]
        public void Push_And_Pop_Values()
        {
            // assign
            var myStack = new MyStack<int>();

            // act
            myStack.Push(111);
            myStack.Push(222);
            myStack.Push(333);
            myStack.Push(444);
            myStack.Push(555);

            // assert
            myStack.Count.ShouldBe(5);

            var scratch1 = myStack.Peek();
            scratch1.ShouldBe(555);

            var scratch2 = myStack.Pop();
            scratch2.ShouldBe(555);

            var scratch3 = myStack.Pop();
            scratch3.ShouldBe(444);

            myStack.Pop();
            myStack.Pop();

            myStack.Count.ShouldBe(1);

            var scratch4 = myStack.Pop();
            scratch4.ShouldBe(111);

            myStack.Count.ShouldBe(0);
        }

    }
}