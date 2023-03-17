namespace LeetCode;

public class CastleOnTheGridTests {

    public static IEnumerable<object[]> GetTestData() {
        // yield return new object[]{
        //     new List<string>{
        //         ".X.",
        //         ".X.",
        //         "...",
        //     },
        //     0,0,
        //     0,2,
        //     3
        //     };

        yield return new object[]{
            new List<string>{
                "X..XX...X:",
                "X.........",
                ".X.......X",
                "..........",
                "........X.",
                ".X...XXX..",
                ".....X..XX",
                ".....X.X..",
                "..........",
                ".....X..XX"
            },
            9,1,
            9,6,
            3
            };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public static void MinimumMovesTests(List<string> grid, int startX, int startY, int goalX, int goalY, int expected) {

        int actual = CastleOnTheGrid.MinimumMoves(grid, startX, startY, goalX, goalY);

        Assert.Equal(expected, actual);
    }
}