namespace LeetCode;

public class UniquePaths
{
    public int Execute(int m, int n)
    {
        int[,] count = new int[m, n];

        return ExecuteRecursive(0, 0, m - 1, n - 1, ref count);
    }

    public int ExecuteDP(int m, int n)
    {
        int[,] dp = new int[m, n];
        for (int i = 0; i < m; i++)
            dp[i, 0] = 1;
        for (int i = 0; i < n; i++)
            dp[0, i] = 1;

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
            }
        }

        return dp[m - 1, n - 1];
    }

    private int ExecuteRecursive(int i, int j, int imax, int jmax, ref int[,] count)
    {
        if (i == imax && j == jmax)
        {
            return 1;
        }

        if (count[i, j] == 0)
        {
            if (i < imax)
            {
                count[i, j] += ExecuteRecursive(i + 1, j, imax, jmax, ref count);
            }
            if (j < jmax)
            {
                count[i, j] += ExecuteRecursive(i, j + 1, imax, jmax, ref count);
            }
        }

        return count[i, j];
    }
}