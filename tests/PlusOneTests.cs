namespace LeetCode;


public class PlusOneTests
{

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 5 })]
    [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
    [InlineData(new int[] { 1, 2, 9, 9 }, new int[] { 1, 3, 0, 0 })]
    [InlineData(new int[] { 9, 9, 8, 9 }, new int[] { 9, 9, 9, 0 })]
    [InlineData(new int[] { 9, 9, 9, 9 }, new int[] { 1, 0, 0, 0, 0 })]
    public void TestTrue(int[] digits, int[] expected)
    {

        PlusOne po = new();
        int[] actual = po.Execute(digits);

        Assert.Equal(expected, actual);
    }
}