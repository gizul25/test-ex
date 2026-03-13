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

    [Theory]
    [InlineData("a   b", 2)]
    [InlineData("a\u00A0\u00A0\u00A0c", 2)]
    [InlineData("a\u2000\u2000\u2000d", 2)]
    public void WordCount_UnicodeMultipleWhitespaceSymbols(string input, int expected)
    {
        var stringUtils = new StringUtils();

        var result = stringUtils.WordCount(input);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("  a a", 2)]
    // Practically incorrect handling of Unicode whitespace symbols doesn't cause issues
    [InlineData("\u00A0\u00A0b b", 2)]
    [InlineData("\u2000\u2000c c", 2)]
    public void WordCount_UnicodeWhitespaceStart(string input, int expected)
    {
        var stringUtils = new StringUtils();

        var result = stringUtils.WordCount(input);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("  e e", 2)]
    [InlineData(" \u00A0\u2000f f", 2)]
    [InlineData("\u00A0 \u2000g g", 2)]
    public void WordCount_UnicodeWhitespaceStart2(string input, int expected)
    {
        var stringUtils = new StringUtils();

        var result = stringUtils.WordCount(input);

        Assert.Equal(expected, result);
    }
}