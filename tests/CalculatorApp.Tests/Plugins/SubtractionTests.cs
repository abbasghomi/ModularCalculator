using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests.Plugins
{
    public class SubtractionTests
    {
        [Fact]
        public void Operate_ShouldReturnCorrectDifference_ForTwoNumbers()
        {
            // Arrange
            var subtraction = new Subtraction.Subtraction();
            double a = 10;
            double b = 5;

            // Act
            var result = subtraction.Operate(a, b);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Symbol_ShouldReturnCorrectSymbol()
        {
            // Arrange
            var subtraction = new Subtraction.Subtraction();

            // Act
            var symbol = subtraction.Symbol;

            // Assert
            Assert.Equal("-", symbol);
        }
    }
}
