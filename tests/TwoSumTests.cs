namespace LeetCode;
public class TwoSumTests
{
    [Theory]
    [InlineData(new int[] { 2, 3, 7, 11, 15 }, 9, new int[] { 0, 2 })]
    [InlineData(new int[] { 2, 3, 3, 7, 11, 15 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 2, 3, 4 }, 6, new int[] { 0, 2 })]

    public void TwoSumTestTrue(int[] nums, int target, int[] expected)
    {
        int[] actual = TwoSum.ExecuteWithSort(nums, target);

        Assert.Equal(expected, actual);
    }
}