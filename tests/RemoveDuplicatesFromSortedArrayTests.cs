namespace LeetCode;

public class RemoveDuplicatesFromSortedArrayTests
{

    [Theory]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 3, 4 }, 5,
    new int[] { 0, 1, 2, 3, 4 })]
    public void TestTrue(int[] nums, int expectedLen, int[] expectedArr)
    {
        RemoveDuplicatesFromSortedArray s = new RemoveDuplicatesFromSortedArray();
        int actual = s.Execute(nums);

        Assert.Equal(expectedLen, actual);

        for (int i = 0; i < expectedLen; i++)
        {
            Assert.Equal(expectedArr[i], nums[i]);
        }

    }

}