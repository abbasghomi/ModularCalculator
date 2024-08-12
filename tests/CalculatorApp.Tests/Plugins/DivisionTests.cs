using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests.Plugins
{
    public class DivisionTests
    {
        [Fact]
        public void Operate_ShouldReturnCorrectQuotient_ForTwoNumbers()
        {
            // Arrange
            var division = new Division.Division();
            double a = 10;
            double b = 5;

            // Act
            var result = division.Operate(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Operate_ShouldThrowException_WhenDividingByZero()
        {
            // Arrange
            var division = new Division.Division();
            double a = 10;
            double b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => division.Operate(a, b));
        }

        [Fact]
        public void Symbol_ShouldReturnCorrectSymbol()
        {
            // Arrange
            var division = new Division.Division();

            // Act
            var symbol = division.Symbol;

            // Assert
            Assert.Equal("/", symbol);
        }
    }
}
