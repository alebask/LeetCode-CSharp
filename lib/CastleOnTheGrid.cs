namespace LeetCode;

public class CastleOnTheGrid {

    public static int MinimumMoves(List<string> grid, int startX, int startY, int goalX, int goalY) {

        int n = grid.Count;
        int[,] distance = new int[n, n];

        Queue<(int, int)> q = new();
        q.Enqueue((startX, startY));
        distance[startX, startY] = 0;

        while (q.Count > 0) {

            (int x, int y) = q.Dequeue();

            if (x == goalX && y == goalY) {
                break;
            }

            //left
            int i = y - 1;
            while (i >= 0 && grid[x][i] != 'X') {
                if (distance[x, i] == 0) {
                    q.Enqueue((x, i));
                    distance[x, i] = 1 + distance[x, y];
                }
                i--;
            }

            //right
            i = y + 1;
            while (i < n && grid[x][i] != 'X') {
                if (distance[x, i] == 0) {
                    q.Enqueue((x, i));
                    distance[x, i] = 1 + distance[x, y];
                }
                i++;
            }

            //up
            i = x - 1;
            while (i >= 0 && grid[i][y] != 'X') {
                if (distance[i, y] == 0) {
                    q.Enqueue((i, y));
                    distance[i, y] = 1 + distance[x, y];
                }
                i--;
            }

            //down
            i = x + 1;
            while (i < n && grid[i][y] != 'X') {
                if (distance[i, y] == 0) {
                    q.Enqueue((i, y));
                    distance[i, y] = 1 + distance[x, y];
                }
                i++;
            }
        }

        return distance[goalX, goalY];
    }
}