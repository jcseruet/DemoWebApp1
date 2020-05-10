using System;
using System.Collections.Generic;
using System.Text;
using DemoWebApp.Mathematics;
using NUnit.Framework;

namespace DemoWebApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase(10, 20, 30)]
        [TestCase(10.5, 1.5, 12.0)]
        public void SumTest(double numberA, double numberB, double sumExpected)
        {
            var calculator = new Calculator();
            var sum = calculator.Sum(numberA, numberB);
            Assert.AreEqual(sumExpected, sum);
        }
    }
}
