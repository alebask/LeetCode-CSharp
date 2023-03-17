namespace LeetCode;

public class FirstLastPositionsTests
{

    [Theory]
    [InlineData(new int[] { 1, 2 }, 1, new int[] { 0, 0 })]
    [InlineData(new int[] { 1, 2 }, 2, new int[] { 1, 1 })]
    [InlineData(new int[] { 1, 2 }, 3, new int[] { -1, -1 })]
    [InlineData(new int[] { }, 0, new int[] { -1, -1 })]
    [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4 })]
    [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 6, new int[] { -1, -1 })]
    [InlineData(new int[] { 1, 2, 3 }, 2, new int[] { 1, 1 })]
    [InlineData(new int[] { 1, 2, 3 }, 1, new int[] { 0, 0 })]
    [InlineData(new int[] { 1, 2, 3 }, 3, new int[] { 2, 2 })]

    public void ExecuteTest(int[] nums, int target, int[] expected)
    {
        FirstLastPositions flp = new();
        int[] actual = flp.SearchRange2(nums, target);

        Assert.Equal(expected, actual);
    }
}