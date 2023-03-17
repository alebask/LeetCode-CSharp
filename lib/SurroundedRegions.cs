namespace LeetCode;

public class SurroundedRegions {

    private int h;
    private int v;
    private char[][]? b;

    public void Solve(char[][] board) {

        v = board.Length - 1;
        h = board[0].Length - 1;
        b = board;

        if (h < 2 || v < 2) {
            return;
        }

        for (int i = 0; i <= v; i++) {
            if (b[i][0] == 'O') {
                saveRegion(i, 0);
            }
            if (b[i][h] == 'O') {
                saveRegion(i, h);
            }
        }
        for (int j = 1; j <= h - 1; j++) {
            if (b[0][j] == 'O') {
                saveRegion(0, j);
            }
            if (b[v][j] == 'O') {
                saveRegion(v, j);
            }
        }

        for (int i = 0; i <= v; i++) {
            for (int j = 0; j <= h; j++) {
                if (b[i][j] == 'S') {
                    b[i][j] = 'O';
                } else if (b[i][j] == 'O') {
                    b[i][j] = 'X';
                }
            }
        }
    }

    private void saveRegion(int i, int j) {

        b![i][j] = 'S';

        if (i + 1 <= v && b[i + 1][j] == 'O') {
            saveRegion(i + 1, j);
        }
        if (i - 1 >= 0 && b[i - 1][j] == 'O') {
            saveRegion(i - 1, j);
        }
        if (j + 1 <= h && b[i][j + 1] == 'O') {
            saveRegion(i, j + 1);
        }
        if (j - 1 >= 0 && b[i][j - 1] == 'O') {
            saveRegion(i, j - 1);
        }
    }
}