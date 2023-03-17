namespace LeetCode;

public class WildcardMatchingTests
{

    [Theory]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "*", true)]
    [InlineData("cb", "?a", false)]
    [InlineData("", "******", true)]
    [InlineData("abcdddefg", "abc*d*efg*", true)]
    [InlineData("ssabcddddddefg", "*abcddd*efg", true)]
    [InlineData("abcdxxefg", "abc*efg", true)]
    [InlineData("abcd", "abcd*", true)]
    [InlineData("bcde", "abcde", false)]
    [InlineData("abcdefg", "?*f", false)]
    [InlineData("aaa", "a*", true)]
    [InlineData("a", "a*", true)]
    [InlineData("abcd", "?*", true)]
    [InlineData("a", "?", true)]
    [InlineData("aab", "a*b", true)]
    [InlineData("a", "*a", true)]
    [InlineData("a", "ab*a", false)]
    [InlineData("ddabc", "d?abc", true)]
    [InlineData("ddabc", "dd*dabc", false)]
    [InlineData("mississippi", "m??*ss*?i*pi", false)]
    // [InlineData("aaabbbaabaaaaababaabaaabbabbbbbbbbaabababbabbbaaaaba", "a*******b", false)]
    // [InlineData("abbabaaabbabbaababbabbbbbabbbabbbabaaaaababababbbabababaabbababaabbbbbbaaaabababbbaabbbbaabbbbababababbaabbaababaabbbababababbbbaaabbbbbabaaaabbababbbbaababaabbababbbbbababbbabaaaaaaaabbbbbaabaaababaaaabb", "**aa*****ba*a*bb**aa*ab****a*aaaaaa***a*aaaa**bbabb*b*b**aaaaaaaaa*a********ba*bbb***a*ba*bb*bb**a*b*bb", false)]
    // [InlineData("abbabaaabbabbaababbabbbbbabbbabbbabaaaaababababbbabababaabbababaabbbbbbaaaabababbbaabbbbaabbbbababababbaabbaababaabbbababababbbbaaabbbbbabaaaabbababbbbaababaabbababbbbbababbbabaaaaaaaabbbbbaabaaababaaaabb", "*aa*ba*a*bb*aa*ab*a*aaaaaa*a*aaaa*bbabb*b*b*aaaaaaaaa*a*ba*bbb*a*ba*bb*bb*a*b*bb", false)]
    [InlineData("bbbb", "*b**", true)]

    public void IsMatchTest(string s, string p, bool expected)
    {

        WildcardMatching wm = new();

        //bool actual = wm.IsMatchRecursive(s, p, new Dictionary<(string, string), bool>());
        bool actual = wm.IsMatch(s, p);

        Assert.Equal(expected, actual);
    }
}