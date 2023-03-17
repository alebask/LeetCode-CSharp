namespace LeetCode;

public class ArrayRotationTests
{

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    public void ExecuteTests1(int[] nums, int k, int[] expected)
    {
        (new ArrayRotation()).Rotate1(nums, k);

        Assert.Equal(expected, nums);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    public void ExecuteTests2(int[] nums, int k, int[] expected)
    {

        (new ArrayRotation()).Rotate2(nums, k);

        Assert.Equal(expected, nums);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    public void ExecuteTests3(int[] nums, int k, int[] expected)
    {

        (new ArrayRotation()).Rotate3(nums, k);

        Assert.Equal(expected, nums);
    }
}