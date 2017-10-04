using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLearningAlgorithms;

namespace MyLearningAlgorithmsTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void TestFibonacci()
        {
            var fib = new Fibonacci();
            var data = fib.GetFibonacciIterativeWay(9);

            Assert.AreEqual(34, data);

            data = fib.GetFibonacciReccursiveWay(9);
            Assert.AreEqual(34, data);
        }
    }
}
