namespace LeetCode;

public class KthLargestElementTests
{
    [Theory]
    [InlineData(new int[] { 3, 2, 1, 5, 6, 4 }, 2, 5)]
    [InlineData(new int[] { 7, 3, 2, 3, 4, 2, 4, 5, 5, 6 }, 4, 5)]
    public void ExecuteTests(int[] nums, int k, int expected)
    {
        KthLargestElement kle = new();
        int actual = kle.FindKthLargestQuickSort(nums, k);

        Assert.Equal(expected, actual);
    }
}