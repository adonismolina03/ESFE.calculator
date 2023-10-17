using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ESFE.Calculadora.UnitTest.AppxUnit
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            Calculator calculator = new Calculator();
            double num1 = 5.0;
            double num2 = 3.0;

            double result = calculator.Add(num1, num2);

            Assert.Equal(8.0, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            Calculator calculator = new Calculator();
            double num1 = 8.0;
            double num2 = 3.0;

            double result = calculator.Subtract(num1, num2);

            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            Calculator calculator = new Calculator();
            double num1 = 4.0;
            double num2 = 2.0;

            double result = calculator.Multiply(num1, num2);

            Assert.Equal(8.0, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            Calculator calculator = new Calculator();
            double num1 = 10.0;
            double num2 = 2.0;

            double result = calculator. Divide(num1, num2);

            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ShoulThrowException()
        {
            Calculator calculator = new Calculator();
            double num1 = 5.0;
            double num2 = 0.0;

            Assert.Throws<ArgumentException>(()=> calculator.Divide(num1, num2));
        }
    }
}
