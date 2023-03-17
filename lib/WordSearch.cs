namespace LeetCode;

public class WordSearch {

    private int m;
    private int n;
    private char[][]? b;
    private string? w;
    private int wl;
    private bool[,]? visited;


    public bool Exist(char[][] board, string word) {

        m = board.Length;
        n = board[0].Length;
        b = board;
        w = word;
        wl = word.Length;
        visited = new bool[m, n];

        if (word.Length > m * n) {
            return false;
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {

                if (b[i][j] == w[0]) {

                    if (WordExist(i, j, 0)) {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    private bool WordExist(int i, int j, int k) {

        if (k == wl) {
            return true;
        }

        if (i < 0 || i >= m || j < 0 || j >= n || w![k] != b![i][j] || visited![i, j]) {
            return false;
        }

        visited[i, j] = true;

        if (WordExist(i - 1, j, k + 1) ||
            WordExist(i + 1, j, k + 1) ||
            WordExist(i, j - 1, k + 1) ||
            WordExist(i, j + 1, k + 1)) {
            return true;
        }

        visited[i, j] = false;

        return false;
    }
}