using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using FluentAssertions;

namespace Example.Tests
{
public class CalculatorTest
{
    [Fact]
    public void Divided_DividedFourAndTwo_ResultShouldBeTwo()
    {
        // Arrange:
        Calculator calc = new Calculator();

        // Act:
        var result = calc.Divided(4, 2);

        // Assert:
        result.Should().Be(2);
    }
    [Fact]
    public void Divided_DividedByZero_ResultShouldThrowDivideByZeroException()
    {
        // Arrange:
        Calculator calc = new Calculator();

        // Act:
        var result = new Action(() => { calc.Divided(4, 0); });

        // Assert:
        result.ShouldThrow<DivideByZeroException>();
    }
}
}
