namespace CalculatorApp.Tests.Plugins
{
    public class AdditionTests
    {
        [Fact]
        public void Operate_ShouldReturnCorrectSum_ForTwoNumbers()
        {
            // Arrange
            var addition = new Addition.Addition();
            double a = 10;
            double b = 5;

            // Act
            var result = addition.Operate(a, b);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Symbol_ShouldReturnCorrectSymbol()
        {
            // Arrange
            var addition = new Addition.Addition();

            // Act
            var symbol = addition.Symbol;

            // Assert
            Assert.Equal("+", symbol);
        }
    }
}
