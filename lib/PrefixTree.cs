namespace LeetCode;

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
        n.IsEndOfWord = true;
    }

    public bool Search(string word) {
        Node? n = Find(word);
        return (n != null) && n.IsEndOfWord;
    }

    public bool StartsWith(string prefix) {
        Node? n = Find(prefix);
        return (n != null);
    }

    public Node? Find(string word) {
        Node n = root;
        for (int i = 0, l = word.Length; i < l; i++) {
            int j = word[i] - 'a';
            if (n[j] == null)
                return null;
            n = n[j];
        }
        return n;
    }

    public class Node {
        public Node[] Children;
        public bool IsEndOfWord;

        public Node() {
            this.Children = new Node[ALPHABET_SIZE];
        }

        public Node(bool endOfWord) : this() {
            this.IsEndOfWord = endOfWord;
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

