using Xunit;
using XUnitDemo;

namespace XUnitDemo.Tests;

public class StringUtilsTests
{
    [Theory]
    [InlineData("a b", 2)]
    [InlineData("a\u00A0c", 2)]
    [InlineData("a\u2000d", 2)]
    public void WordCount_UnicodeWhitespaceSymbols(string input, int expected)
    {
        var stringUtils = new StringUtils();

        var result = stringUtils.WordCount(input);

        Assert.Equal(expected, result);
    }
}