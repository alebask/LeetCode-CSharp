namespace LeetCode;

public class FirstMissingPositiveTests {
    [Theory]
    [InlineData(new int[] { -11, -2, 0 }, 1)]
    [InlineData(new int[] { 1, 2 }, 3)]
    [InlineData(new int[] { -1, 0, 1, 2 }, 3)]
    [InlineData(new int[] { 3, 4, -1, 1 }, 2)]
    [InlineData(new int[] { 0, -20, 2, 3, 9, 8, 4, -11, -10, 1 }, 5)]
    [InlineData(new int[] { 7, 8, 9, 11, 12 }, 1)]
    public void ExecuteTest(int[] nums, int expected) {
        FirstMissingPositive fmp = new();
        int actual = fmp.Execute(nums);
        Assert.Equal(actual, expected);
    }
}