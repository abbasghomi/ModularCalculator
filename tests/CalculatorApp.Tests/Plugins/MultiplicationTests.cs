using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests.Plugins
{
    public class MultiplicationTests
    {
        [Fact]
        public void Operate_ShouldReturnCorrectProduct_ForTwoNumbers()
        {
            // Arrange
            var multiplication = new Multiplication.Multiplication();
            double a = 10;
            double b = 5;

            // Act
            var result = multiplication.Operate(a, b);

            // Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void Symbol_ShouldReturnCorrectSymbol()
        {
            // Arrange
            var multiplication = new Multiplication.Multiplication();

            // Act
            var symbol = multiplication.Symbol;

            // Assert
            Assert.Equal("*", symbol);
        }
    }
}
