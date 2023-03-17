namespace LeetCode;

public class MaxPointsSolution {

    public int MaxPoints(int[][] points) {


        if (points.Length < 3) {
            return points.Length;
        }

        Dictionary<int, Dictionary<int, int>> lines = new();
        int result = 1;

        for (int i = 0, l = points.Length; i < l - 1; i++) {

            lines.Clear();

            int x1 = points[i][0];
            int y1 = points[i][1];

            for (int j = i + 1; j < l; j++) {

                int x2 = points[j][0];
                int y2 = points[j][1];

                int dy = y2 - y1;
                int dx = x2 - x1;

                int gcd = GCD(dx, dy);

                if (gcd != 0) {
                    dx /= gcd;
                    dy /= gcd;
                }

                if (lines.ContainsKey(dy)) {
                    if (lines[dy].ContainsKey(dx)) {
                        int r = ++lines[dy][dx];
                        result = Math.Max(result, r);
                    } else {
                        lines[dy].Add(dx, 1);
                    }
                } else {
                    lines.Add(dy, new Dictionary<int, int>() { { dx, 1 } });
                }
            }
        }

        return ++result;
    }

    private int GCD(int x, int y) {

        if (x == 0) { return y; }
        return GCD(y % x, x);
    }
}
