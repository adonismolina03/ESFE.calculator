using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESFE.Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.Calculadora.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Add(5,3);
            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Multiply(5, 3);
            Assert.AreEqual(15, result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(6, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideByZeroTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(5, 0);
        }
    }
}