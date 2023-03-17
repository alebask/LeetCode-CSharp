namespace LeetCode;

public class LargestRectangleTests {

    [Theory]
    [InlineData(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    [InlineData(new int[] { 3, 6, 5, 7, 4, 8, 1, 0 }, 20)]
    public void ExecuteTest(int[] heights, int expected) {

        LargestRectangle lr = new();

        int actual = lr.LargestRectangleArea(heights);

        Assert.Equal(expected, actual);

    }
}