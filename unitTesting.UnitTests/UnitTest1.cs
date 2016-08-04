using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using unitTesting.Implementation;

namespace unitTesting.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanMakeInstanceOfMultiply()
        {
            Multiply multiply = new Multiply();
            Assert.IsNotNull(multiply);
        }
        [TestMethod]
        public void MultiplyIntegersTest()
        {
            Multiply multiply = new Multiply();
            int myAnswer = multiply.MultiplyIntegers(3, 5);
            Assert.AreEqual(15, myAnswer);
        }

        [TestMethod]
        public void AnswersReturnsAList()
        {
            Multiply multiply = new Multiply();
            Assert.IsInstanceOfType(multiply.Answers(), typeof(List<int>));
        }

        [TestMethod]
        public void IsEvenReturnsTrue()
        {
            Multiply multiply = new Multiply();
            var istrue = multiply.IsEven(4);
            Assert.IsTrue(istrue);
        }

        [TestMethod]
        public void IsEvenReturnsFalseForOddNumbers()
        {
            Multiply multiply = new Multiply();
            var isfalse = multiply.IsEven(7);
            Assert.IsFalse(isfalse);
        }
    }
}
