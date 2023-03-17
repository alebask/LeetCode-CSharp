namespace LeetCode;

public class SqrtTests
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    [InlineData(0, 0)]
    [InlineData(256, 16)]
    [InlineData(1234567, 1111)]
    [InlineData(2147483647, 46340)]
    public void TestTrue(int x, int expected)
    {
        Sqrt s = new();
        int actual = s.Execute(x);

        Assert.Equal(expected, actual);
    }
}