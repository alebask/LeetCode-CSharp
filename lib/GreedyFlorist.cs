namespace LeetCode;

public class GreedyFloristSolition {

    static int GetMinimumCost(int k, int[] c) {

        int n = c.Length;
        int sum = 0;

        if (k >= n) {
            for (int i = 0; i < n; i++) {
                sum += c[i];
            }
        } else {
            Array.Sort<int>(c, new Comparison<int>((c1, c2) => -c1.CompareTo(c2)));
            int j = 0;
            for (int i = 0; i < n; i++) {
                sum += c[i] * (j / k + 1);
                j++;
            }

        }

        return sum;
    }
}