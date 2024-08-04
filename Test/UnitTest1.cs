using System;
using Xunit;
using Calculator;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void ReturnZeroOnEmptyString()
    {
        int expected = 0;
        int result = new SetCalculator().add("");

        Assert.Equal(expected, result);
    }
}