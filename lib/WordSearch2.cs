namespace LeetCode;

public class WordSearch2 {

    int m;
    int n;
    char[][]? board;
    Trie? tr;
    IList<string>? result;

    public IList<string> FindWords(char[][] board, string[] words) {

        tr = new();
        foreach (string word in words) {
            tr.Insert(word);
        }

        m = board.Length;
        n = board[0].Length;
        this.board = board;

        result = new List<string>();

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                FindWord(tr.root, i, j);
            }
        }

        return result.ToArray();
    }

    public void FindWord(Trie.Node node, int i, int j) {

        char ch = board![i][j];

        if (ch == 'X' || node[ch - 'a'] == null) {
            return;
        }

        node = node[ch - 'a'];

        if (node == null) {
            return;
        } else if (node.Word != null) {
            result!.Add(node.Word);
            node.Word = null; //deduplicate
        }

        board[i][j] = 'X';

        if (i > 0) FindWord(node, i - 1, j);
        if (i < m - 1) FindWord(node, i + 1, j);
        if (j > 0) FindWord(node, i, j - 1);
        if (j < n - 1) FindWord(node, i, j + 1);

        board[i][j] = ch;
    }

    public class Trie {
        private static readonly int ALPHABET_SIZE = 26;

        public readonly Node root;

        public Trie() {
            this.root = new Node();
        }

        public void Insert(string word) {
            Node n = root;
            for (int i = 0, l = word.Length; i < l; i++) {
                int j = word[i] - 'a';
                if (n[j] == null)
                    n[j] = new Node();
                n = n[j];
            }
            n.Word = word;
        }

        public class Node {
            public Node[] Children;
            public string? Word;

            public Node() {
                this.Children = new Node[ALPHABET_SIZE];
            }

            public Node(string word) : this() {
                this.Word = word;
            }

            public Node this[int index] {
                get {
                    return this.Children[index];
                }
                set {
                    this.Children[index] = value;
                }
            }
        }
    }
}