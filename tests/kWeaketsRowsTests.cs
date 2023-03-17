namespace LeetCode;

public class KWeakestRowsTests
{
    ///tests

    private static void ExecuteAssertEqual(int[][] mat, int k, int[] expected)
    {

        int[] actual = KWeakestRows.Execute(mat, k);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void KWeakestRowsTest1()
    {
        int[][] mat =   {new int[] {1, 1, 0, 0, 0},
                         new int[] {1, 1, 1, 1, 0},
                         new int[] {1, 0, 0, 0, 0},
                         new int[] {1, 1, 0, 0, 0},
                         new int[] {1, 1, 1, 1, 1}};

        int k = 3;

        int[] expected = { 2, 0, 3 };

        ExecuteAssertEqual(mat, k, expected);
    }

    [Fact]
    public void KWeakestRowsTest2()
    {
        int[][] mat =   {new int[] {1, 0, 0, 0},
                         new int[] {1, 1, 1, 1},
                         new int[] {1, 0, 0, 0},
                         new int[] {1, 0, 0, 0}};

        int k = 2;

        int[] expected = { 0, 2 };

        ExecuteAssertEqual(mat, k, expected);
    }

    [Fact]
    public void KWeakestRowsTest3()
    {
        int[][] mat =   {new int[] {1, 1, 1, 1, 1},
                         new int[] {1, 0, 0, 0, 0},
                         new int[] {1, 1, 0, 0, 0},
                         new int[] {1, 1, 1, 1, 0},
                         new int[] {1, 1, 1, 1, 1}};

        int k = 3;

        int[] expected = { 1, 2, 3 };

        ExecuteAssertEqual(mat, k, expected);
    }

}