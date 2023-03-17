namespace LeetCode;

public class ThreeSumTests
{

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void ExecuteTests(int[] nums, int[][] expected)
    {

        int[][] actual = ThreeSum.Execute2(nums);

        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[]{
            new int[] { -1, 0, 1, 2, -1, -4 },
            new List<int[]> {  new int[] { -1, -1, 2 }, new int[] { -1, 0, 1 }}
         };

        yield return new object[]{
            new int[] { 0,1,1 },
            Array.Empty<int[]>()
         };

        yield return new object[]{
            new int[] { 0,0,0 },
            new int[][] { new int[] { 0,0,0 } }
         };
    }
}