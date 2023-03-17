namespace LeetCode;

public class MergeSortedArraysTests
{

    [Theory]
    [InlineData(new int[] { 1, 3, 7, 0, 0, 0, 0 }, 3,
                new int[] { 1, 2, 5, 6 }, 4,
                new int[] { 1, 1, 2, 3, 5, 6, 7 })]

    [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3,
                new int[] { 2, 5, 6 }, 3,
                new int[] { 1, 2, 2, 3, 5, 6 })]

    [InlineData(new int[] { 1 }, 1,
                new int[] { }, 0,
                new int[] { 1 })]

    [InlineData(new int[] { 0 }, 0,
                new int[] { 1 }, 1,
                new int[] { 1 })]

    public void TestMergeTrue(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        MergeSortedArrays msa = new();
        msa.Merge(nums1, m, nums2, n);

        int[] actual = nums1;

        Assert.Equal(expected, actual);

    }
}