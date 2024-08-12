using CalculatorApp.Services;
using CalculatorApp.Tests.Helpers;

namespace CalculatorApp.Tests.Services;

public class CalculatorAppTests
{
    [Fact]
    public void Run_ShouldDisplayAvailableOperations_WhenPluginsAreLoaded()
    {
        // Arrange
        var calculatorApp = new CalculatorApp();
        calculatorApp.Operations = new List<IOperation>
        {
            new Addition.Addition(),
            new Subtraction.Subtraction(),
            new Multiplication.Multiplication(),
            new Division.Division()
        };

        // Simulate user input
        var inputs = new[] { "10", "5" }; // Enter two numbers
        using var consoleInput = new ConsoleInput(inputs);

        // Capture console output
        using var consoleOutput = new ConsoleOutput();

        // Act
        calculatorApp.Run();

        // Assert
        var output = consoleOutput.GetOutput();
        Assert.Contains("Available operations:", output);
        Assert.Contains("+ - Addition", output);
        Assert.Contains("- - Subtraction", output);
        Assert.Contains("* - Multiplication", output);
        Assert.Contains("/ - Division", output);
    }

    [Theory]
    [InlineData(10, 5, "+", 15)]
    [InlineData(10, 5, "-", 5)]
    [InlineData(10, 5, "*", 50)]
    [InlineData(10, 5, "/", 2)]
    public void Run_ShouldReturnCorrectResult_ForGivenOperation(double a, double b, string symbol, double expectedResult)
    {
        // Arrange
        var calculatorApp = new CalculatorApp();
        calculatorApp.Operations = new List<IOperation>
            {
                new Addition.Addition(),
                new Subtraction.Subtraction(),
                new Multiplication.Multiplication(),
                new Division.Division()
            };

        // Capture console input/output
        var inputs = new[] { a.ToString(), b.ToString(), symbol };
        using var consoleOutput = new ConsoleOutput();
        using var consoleInput = new ConsoleInput(inputs);

        // Act
        calculatorApp.Run();

        // Assert
        var output = consoleOutput.GetOutput();
        Assert.Contains($"Result: {expectedResult}", output);
    }
}