
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Calculator;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTestsClass
    {
        [TestMethod]
        public void SumTest()
        {
            double a = 5;
            double b = 23;

            var expected = a + b;

            Assert.AreEqual(expected, Program.Sum(a, b));
        }

        [TestMethod]
        public void SubtractionTest()
        {
            double a = 5;
            double b = 23;

            var expected = a - b;

            Assert.AreEqual(expected, Program.Subtract(a, b));
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            double a = 5;
            double b = 23;

            var expected = a * b;

            Assert.AreEqual(expected, Program.Multiple(a, b));
        }

        [TestMethod]
        public void DivisionTest()
        {
            double a = 5;
            double b = 23;

            var expected = a / b;

            Assert.AreEqual(expected, Program.Divide(a, b));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroExceprion()
        {
            double a = 5;
            double b = 0;

            var expected = a / b;

            Assert.AreEqual(expected, Program.Divide(a, b));
        }
    }
}
