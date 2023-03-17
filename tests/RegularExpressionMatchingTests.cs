namespace LeetCode;

public class RegularExpressionMatchingTests
{
    [Theory]
    [InlineData("abcdddefg", "abc*d*efg*", true)]
    [InlineData("abcddddddefg", "d*abcddd*efg", true)]
    [InlineData("abcdxxefg", "abc.*efg", true)]
    [InlineData("abcd", "abcd*", true)]
    [InlineData("bcde", "abcde", false)]
    [InlineData("abcdefg", ".*f", false)]
    [InlineData("aaa", "a*", true)]
    [InlineData("a", "a*", true)]
    [InlineData("abcd", ".*", true)]
    [InlineData("aa", "a", false)]
    [InlineData("a", ".", true)]
    [InlineData("aab", "c*a*b", true)]
    [InlineData("a", "c*b*a", true)]
    [InlineData("a", "ab*a", false)]
    [InlineData("ddabc", "d.*abc", true)]
    [InlineData("ddabc", "ddd.*abc", false)]

    public void IsMatchTest(string s, string p, bool expected)
    {
        RegularExpressionMatching rem = new();

        bool actual = rem.IsMatch(s, p);

        Assert.Equal(expected, actual);
    }
}

//abcddddddefg
//d*abcddd*efg

//ddabc
//.*abc

// bcde
//abcde

//"abcdxxefg"
// "abc.*efg"