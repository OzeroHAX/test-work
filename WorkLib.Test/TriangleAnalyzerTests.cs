using System;
using Xunit;

namespace WorkLib.Test;

public class TriangleAnalyzerTests
{
    [Theory]
    [InlineData(3, 4, 5, TriangleType.Rectangular)]
    [InlineData(5, 12, 13, TriangleType.Rectangular)]
    [InlineData(7, 24, 25, TriangleType.Rectangular)]
    [InlineData(2, 2, 2, TriangleType.Sharp)]
    [InlineData(7, 10, 5, TriangleType.Obtuse)]
    [InlineData(10, 10, 15, TriangleType.Obtuse)]
    public void DetermineTriangleType_ReturnsCorrectType(double a, double b, double c, TriangleType expected)
    {
        // Act
        var result = TriangleAnalyzer.DetermineTriangleType(a, b, c);

        // Assert
        Assert.Equal(expected, result);
    }
}