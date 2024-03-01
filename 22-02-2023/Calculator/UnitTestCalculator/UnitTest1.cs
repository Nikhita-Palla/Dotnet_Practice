using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTestMethod()
        {
            CalculatorClass calculator = new CalculatorClass();
            int res = calculator.Add(1, 2);
            Assert.AreEqual(3, res);

        }
        [TestMethod]
        public void SubtractTestMethod()
        {
            CalculatorClass calculator = new CalculatorClass();
            int res = calculator.Subtract(2, 2);
            Assert.AreEqual(0, res);

        }
        [TestMethod]
        public void MultiplyTestMethod()
        {
            CalculatorClass calculator = new CalculatorClass();
            int res = calculator.Multiply(2, 8);
            Assert.AreEqual(4, res);

        }
        [TestMethod]
        public void DivideTestMethod()
        {
            CalculatorClass calculator = new CalculatorClass();
            int res = calculator.Divide(2, 2);
            Assert.AreEqual(1, res);

        }
    }
}
