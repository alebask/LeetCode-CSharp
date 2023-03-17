namespace LeetCode;

public class MyAtoiTests
{
    [Theory]
    [InlineData("  +456 with words", 456)]
    [InlineData("  -456 with words", -456)]
    [InlineData("  +456023750923475 with words", Int32.MaxValue)]
    [InlineData("-45602375092347599 with words", Int32.MinValue)]
    [InlineData("  ", 0)]
    [InlineData("+-12", -0)]
    public void MyAtoiTestsTrue(string s, int expected)
    {
        MyAtoi atoi = new();

        int actual = atoi.Execute(s);

        Assert.Equal(expected, actual);

    }
}