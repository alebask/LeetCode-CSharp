namespace LeetCode;

public class ReserseIntegerTests
{
    [Theory]
    [InlineData(1234567899, 0)]
    [InlineData(12345, 54321)]
    [InlineData(1, 1)]
    [InlineData(12, 21)]
    [InlineData(-123, -321)]
    [InlineData(2147483647, 0)]

    public void ReverseTest(int x, int expected)
    {
        ReverseInteger ri = new();
        int actual = ri.Reverse(x);

        Assert.Equal(expected, actual);

    }
}