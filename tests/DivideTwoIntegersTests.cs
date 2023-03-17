namespace LeetCode;

public class DidivdeTwoIntegersTests
{
    [Theory]
    [InlineData(int.MinValue, -1, int.MaxValue)]
    [InlineData(int.MinValue, 1, int.MinValue)]
    [InlineData(int.MinValue, int.MaxValue, -1)]
    [InlineData(10, 3, 10 / 3)]
    [InlineData(85, 7, 85 / 7)]

    public void DivideTest(int dividend, int divisor, int expected)
    {

        DidivdeTwoIntegers dti = new();
        int actual = dti.Divide(dividend, divisor);

        Assert.Equal(expected, actual);

    }

}
