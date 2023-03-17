namespace LeetCode;

public class PalindromePartitioningTests {

    // [Fact(Skip = "for debugging only")]
    [Fact]
    public void ExecuteTests() {

        string s = "acaacab";

        IList<IList<string>> expected = new List<IList<string>>();

        PalindromePartitioning pp = new();

        IList<IList<string>> actual = pp.Partition(s);

        Assert.Equal(expected, actual);
    }

}