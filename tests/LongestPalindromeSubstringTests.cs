
namespace LeetCode
{

    public class LongestPalindromeSubstringTests
    {

        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("a", "a")]
        [InlineData("aa", "aa")]
        [InlineData("aba", "aba")]
        [InlineData("qweaba", "aba")]
        [InlineData("qwedbb", "bb")]
        [InlineData("aaa", "aaa")]


        public void TestTrue(string s, string expected)
        {

            LongestPalindromeSubstring lps = new();
            string actual = lps.Execute(s);

            Assert.Equal(expected, actual);
        }
    }
}