using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Prak5;

namespace Prak5Test
{
    [TestClass]
    public class UnitTestCalc
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

            Assert.AreEqual(expected, Program.Subtraction(a, b));
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            double a = 5;
            double b = 23;

            var expected = a * b;

            Assert.AreEqual(expected, Program.Multiplication(a, b));
        }

        [TestMethod]
        public void DivisionTest()
        {
            double a = 5;
            double b = 23;

            var expected = a / b;

            Assert.AreEqual(expected, Program.Division(a, b));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroExceprion()
        {
            double a = 5;
            double b = 0;

            var expected = a / b;

            Assert.AreEqual(expected, Program.Division(a, b));
        }
    }
}
