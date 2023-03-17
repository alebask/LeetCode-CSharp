namespace LeetCode;

public class LongestCommonPrefixTests
{

    [Theory]
    [InlineData(new string[] { "string1", "stecial", "straight" }, "st")]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    [InlineData(new string[] { "dog", "racecar", "" }, "")]
    [InlineData(new string[] { "" }, "")]
    [InlineData(new string[] { "", "b" }, "")]
    [InlineData(new string[] { "a", "ac" }, "a")]
    public void Test1(string[] strs, string expected)
    {
        LongestCommonPrefix lcp = new();

        string actual = lcp.Execute(strs);

        Assert.Equal(expected, actual);
    }
}