namespace LeetCode;

public class MaxPointsTests {

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void MaxPointExecuteTests(int[][] points, int expected) {

        MaxPointsSolution s = new();

        int actual = s.MaxPoints(points);

        Assert.Equal(expected, actual);

    }

    public static IEnumerable<object[]> GetTestData() {

        // yield return new object[]{
        //     new int[][]{
        //         new int[] {0,0},
        //         new int[] {4,5},
        //         new int[] {7,8},
        //         new int[] {8,9},
        //         new int[] {5,6},
        //         new int[] {3,4},
        //         new int[] {1,1}
        //     }, 5
        // };

        // yield return new object[]{
        //     new int[][]{
        //         new int[] {1,1},
        //         new int[] {2,2},
        //         new int[] {3,3}
        //     }, 3
        // };

        yield return new object[]{
            new int[][]{
                new int[] {1,1},
                new int[] {3,2},
                new int[] {5,3},
                new int[] {4,1},
                new int[] {2,3},
                new int[] {1,4},
            }, 4
        };

        // yield return new object[]{
        //     new int[][]{
        //         new int[] {-6,-1},
        //         new int[] {3,1},
        //         new int[] {12,3}
        //     }, 3
        // };

        //[[1,1],[3,2],[5,3],[4,1],[2,3],[1,4]]
    }
}