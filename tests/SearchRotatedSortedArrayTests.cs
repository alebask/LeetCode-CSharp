namespace LeetCode;

public class SearchRotatedSortedArrayTests
{


    [Theory]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    [InlineData(new int[] { 8, 0, 1, 2, 3, 4, 5, 6 }, 0, 1)]
    [InlineData(new int[] { 4, 5, 6, 7, 10, 0, 1, 2, 3 }, 7, 3)]
    [InlineData(new int[] { 1 }, 0, -1)]
    [InlineData(new int[] { 1 }, 1, 0)]
    [InlineData(new int[] { 1, 3 }, 1, 0)]
    [InlineData(new int[] { 1, 3 }, 3, 1)]
    [InlineData(new int[] { 3, 1 }, 3, 0)]
    [InlineData(new int[] { 3, 1 }, 1, 1)]
    [InlineData(new int[] { 1, 3 }, 0, -1)]
    [InlineData(new int[] { 1, 3 }, 2, -1)]
    [InlineData(new int[] { 1, 2, 3 }, 2, 1)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4, 3)]
    public void SearchTest(int[] nums, int target, int expected)
    {
        SearchRotatedSortedArray srsa = new();

        int actual = srsa.Search2(nums, target);

        Assert.Equal(expected, actual);
    }
}