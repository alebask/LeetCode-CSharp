using System.Text;

namespace LeetCode;
public class CrossWorfPuzzleSolution {

    public static List<string> crosswordPuzzle(List<string> crossword, string words) {

        List<string> result = new();
        CrosswordPuzzleR(crossword, result, 0, words.Split(';'));
        return result;
    }

    public static void CrosswordPuzzleR(List<string> crossword, List<string> result, int index, string[] words) {

        if (index == words.Length) {
            result = crossword;
            return;
        }

        int n = 10;
        string word = words[index];
        int wlen = word.Length;

        char[][] board = new char[n][];
        for (int i = 0; i < n; i++) {
            board[i] = crossword[i].ToCharArray();
        }

        //horizontals              
        for (int i = 0; i < n; i++) {
            for (int j = 0; j <= n - wlen; j++) {
                if (TryPutHorizontal(i, j, out int k)) {
                    CrosswordPuzzleR(newCrossword(), result, index + 1, words);
                }
                while (k > 0) {
                    board[i][j] = crossword[i][j];
                    j++;
                    k--;
                }
            }
        }

        //verticals
        for (int j = 0; j < n; j++) {
            for (int i = 0; i <= n - wlen; i++) {
                if (TryPutVertical(i, j, out int k)) {
                    CrosswordPuzzleR(newCrossword(), result, index + 1, words);
                }
                while (k > 0) {
                    board[i][j] = crossword[i][j];
                    i++;
                    k--;
                }
            }
        }


        List<string> newCrossword() {
            List<string> nb = new(n);
            for (int i = 0; i < n; i++) {
                nb.Add(new string(board[i]));
            }
            return nb;
        }

        bool TryPutVertical(int i, int j, out int k) {
            k = 0;
            for (; k < wlen; k++) {
                if ((board[i + k][j] == '-' || board[i + k][j] == word[k])) {
                    board[i + k][j] = word[k];
                } else {
                    return false;
                }
            }

            return true;
        }

        bool TryPutHorizontal(int i, int j, out int k) {
            k = 0;
            for (; k < wlen; k++) {
                if (board[i][j + k] == '-' || board[i][j + k] == word[k]) {
                    board[i][j + k] = word[k];
                } else {
                    return false;
                }
            }

            return true;
        }
    }
}