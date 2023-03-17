namespace LeetCode;

public class JumpGameTests {

    [Theory]
    [InlineData(new int[] { 2, 5, 0, 0 }, true)]
    public void ExecuteTests(int[] nums, bool expected) {

        JumpGame jg = new();
        bool actual = jg.CanJump(nums);

        Assert.Equal(expected, actual);
    }
}