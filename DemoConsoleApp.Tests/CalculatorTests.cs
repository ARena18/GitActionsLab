using DemoConsoleApp;
using Xunit;

namespace DemoConsoleApp.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectValue()
    {
        int result = Calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Add_NegValue_ReturnsCorrectValue()
    {
        int result = Calculator.Add(-2, 3);
        Assert.Equal(1, result);
    }
}
