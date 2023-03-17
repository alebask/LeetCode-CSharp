namespace LeetCode;

public class SpiralMatrixTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void SpiralOrderTests(int[][] matrix, IList<int> expected)
    {
        SpiralMatrix sm = new();

        IList<int> actual = sm.SpiralOrder(matrix);

        Assert.Equal(expected, actual);

    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[]{
            new int[][]{
                new int[]{1, 2, 3 },
                new int[]{4, 5, 6 },
                new int[]{7, 8, 9 }
            },
            new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }
        };

        yield return new object[]{
            new int[][]{
                new int[]{1, 2, 3, 4},
                new int[]{5, 6, 7, 8 },
                new int[]{9,10,11,12 }
            },
            new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }
        };

        yield return new object[]{
            new int[][]{
                new int[]{1,2,3,4,5,6,7,8,9,10},
                new int[]{11,12,13,14,15,16,17,18,19,20 }
            },
            new int[] { 1,2,3,4,5,6,7,8,9,10,20,19,18,17,16,15,14,13,12,11}
        };
    }
}