namespace LeetCode;

public class LRUCache {

    private Dictionary<int, Node> _hash;
    private readonly int _capacity;
    private readonly List _list;

    public LRUCache(int capacity) {

        _capacity = capacity;
        _hash = new Dictionary<int, Node>();
        _list = new List();
    }

    public int Get(int key) {

        if (_hash.ContainsKey(key)) {
            Node node = _hash[key];

            _list.Remove(node);
            _list.AddFirst(node);

            return node.Value;
        }

        return -1;
    }

    public void Put(int key, int value) {

        if (_hash.ContainsKey(key)) {
            Node node = _hash[key];
            node.Value = value;
            _list.Remove(node);
            _list.AddFirst(node);
        } else {
            Node newNode = new(key, value);
            _list.AddFirst(newNode);
            _hash.Add(key, newNode);

            if (_list.Count > _capacity) {
                Node? last = _list.RemoveLast();
                _hash.Remove(last!.Key);
            }
        }
    }

    private class List {

        private Node? _first;
        private Node? _last;

        public int Count;

        public void AddFirst(Node node) {

            if (_first == null) {
                _first = _last = node;
            } else {
                _first.Previous = node;
                node.Previous = null;
                node.Next = _first;
                _first = node;
            }
            Count++;
        }

        public void Remove(Node? node) {

            if (node!.Previous != null) {
                node.Previous.Next = node.Next;
            } else {
                _first = node.Next;
            }
            if (node.Next != null) {
                node.Next.Previous = node.Previous;
            } else {
                _last = node.Previous;
            }
            Count--;
        }
        public Node? RemoveLast() {

            Node? n = _last;
            Remove(_last);
            return n;
        }
    }

    private class Node {

        public int Key;
        public int Value;
        public Node? Next;
        public Node? Previous;

        public Node(int key, int value) {
            this.Key = key;
            this.Value = value;
        }
    }
}