namespace LeetCode;

public class WordLadderTests {

    [Theory]
    //[InlineData("hot", "dog", new string[] { "hot", "dog", "dot" }, 3)]
    [InlineData("a", "c", new string[] { "a", "b", "c" }, 2)]
    public void ExecuteTests(string beginWord, string endWord, IList<string> wordList, int expected) {

        WordLadder wl = new();

        int actual = wl.LadderLength(beginWord, endWord, wordList);

        Assert.Equal(expected, actual);
    }
}