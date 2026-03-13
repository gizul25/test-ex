using Xunit;
using XUnitDemo;

namespace XUnitDemo.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        // Arrange
        var calculator = new Calculator();

        // Act + Assert
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(10, true)]
    [InlineData(11, false)]
    public void IsEven_VariousInputs_ReturnsExpectedResult(int input, bool expected)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.IsEven(input);

        // Assert
        Assert.Equal(expected, result);
    }
}