namespace XUnitDemo;

public class StringUtils
{
    public bool IsPalindrome(string text)
    {
        if (text == null)
            throw new ArgumentNullException(nameof(text));

        var reversed = new string(text.Reverse().ToArray());
        return text == reversed;
    }

    public int WordCount(string sentence)
    {
        if (sentence == null)
            throw new ArgumentNullException(nameof(sentence));

        if (string.IsNullOrWhiteSpace(sentence))
            return 0;

        return sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}