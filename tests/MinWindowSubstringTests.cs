namespace LeetCode;
public class MinWindowSubstringTests {


    [Theory]
    [InlineData("ADOBECODEBANC", "ABC", "BANC")]
    [InlineData("a", "a", "a")]
    [InlineData("a", "aa", "")]
    [InlineData("aa", "a", "a")]
    [InlineData("abc", "bc", "bc")]
    [InlineData("bba", "ab", "ba")]
    [InlineData("aa", "aa", "aa")]
    [InlineData("bbacccccdddd", "kkk", "")]

    public void MinWindowTest(string s, string t, string expected) {

        MinWindowSubstring mws = new();

        string actual = mws.MinWindow(s, t);

        Assert.Equal(expected, actual);
    }
}