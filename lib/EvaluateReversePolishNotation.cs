namespace LeetCode;

public class ReversePolishNotation {

    public int EvalRPN(string[] tokens) {

        if (tokens.Length == 1)
            return int.Parse(tokens[0]);

        Stack<int> ns = new();
        int result = 0;
        for (int i = 0, l = tokens.Length; i < l; i++) {

            int n1, n2;
            switch (tokens[i]) {

                case "+": n1 = ns.Pop(); n2 = ns.Pop(); result = n2 + n1; ns.Push(result); break;
                case "-": n1 = ns.Pop(); n2 = ns.Pop(); result = n2 - n1; ns.Push(result); break;
                case "*": n1 = ns.Pop(); n2 = ns.Pop(); result = n2 * n1; ns.Push(result); break;
                case "/": n1 = ns.Pop(); n2 = ns.Pop(); result = n2 / n1; ns.Push(result); break;
                default: ns.Push(int.Parse(tokens[i])); break;
            }
        }

        return result;
    }

    private class Stack<T> {

        private Item? _head;
        public int Count;

        public void Push(T value) {

            if (_head == null) {
                _head = new Item(value);
            } else {

                Item i = new(value, _head);
                _head = i;
            }
            ++Count;
        }
        public T? Pop() {

            Item h = _head!;
            _head = _head!.Next;

            --Count;

            return h.Value;
        }

        private class Item {
            public T? Value;
            public Item? Next;

            public Item(T? value = default, Item? next = null) {
                this.Value = value;
                this.Next = next;
            }
        }
    }
}
