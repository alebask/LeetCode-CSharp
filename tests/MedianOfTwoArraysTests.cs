namespace LeetCode;

public class MedianOfTwoArraysTests
{
    [Theory]
    [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2)]
    [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
    [InlineData(new int[] { 3, 4 }, new int[] { 1, 2 }, 2.5)]
    [InlineData(new int[] { -5, 3, 6, 12, 15 }, new int[] { -12, -10, -6, -3, 4, 10 }, 3)]
    [InlineData(new int[] { 2, 2, 4, 4 }, new int[] { 2, 2, 4, 4 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 10)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8 }, 4.5)]
    [InlineData(new int[] { 1, 2, 3, 6, 7 }, new int[] { 4, 5, 8 }, 4.5)]
    public void TestTrue(int[] nums1, int[] nums2, double expected)
    {
        MedianOfTwoArrays m = new();

        double actual = m.Execute(nums1, nums2);

        Assert.Equal(expected, actual);
    }
}