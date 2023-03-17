namespace LeetCode;

public class LetterCombinationsPhoneNumberTests
{
    [Theory]
    [InlineData("23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
    [InlineData("2", new string[] { "a", "b", "c" })]
    [InlineData("", new string[] { })]
    public void CartesianProductOfLetters(string digits, string[] expected)
    {
        LetterCombinationsPhoneNumber lcp = new();

        string[] actual = lcp.LetterCombinations(digits).OrderBy(x => x).ToArray();


        Assert.Equal(expected, actual);

    }
}