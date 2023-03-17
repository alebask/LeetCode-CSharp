namespace LeetCode;

public class PoisonousPlantsSolution {

    public static int PoisonousPlants(List<int> p) {

        LinkedList<LinkedList<int>> lists = new();
        lists.AddLast(new LinkedList<int>());
        lists.Last!.Value.AddLast(p[0]);

        for (int i = 1, len = p.Count; i < len; i++) {
            if (p[i - 1] < p[i]) {
                lists.AddLast(new LinkedList<int>());
            }
            lists.Last.Value.AddLast(p[i]);
        }

        int days = 0;

        while (lists.Count > 1) {
            var curr = lists.First!.Next;

            while (curr != null) {
                curr.Value.RemoveFirst();
                if (curr.Value.Count == 0) {
                    lists.Remove(curr);
                } else if (curr.Prev!.Value.Last!.Value >= curr.Value.First!.Value) {
                    curr.Prev!.Value.Append(curr.Value);
                    lists.Remove(curr);
                }
                curr = curr.Next;
            }
            days++;
        }

        return days;
    }

    public class Node<T> {
        public T Value;
        public Node<T>? Next;
        public Node<T>? Prev;

        public Node(T value) {
            this.Value = value;
        }
    }

    public class LinkedList<T> {

        public Node<T>? First { get; private set; }
        public Node<T>? Last { get; private set; }
        public int Count { get; private set; }

        public LinkedList(Node<T>? node = null) {

            if (node != null) {
                AddLast(node);
            }
        }

        public void RemoveFirst() {
            Remove(First);
        }
        public void RemoveLast() {
            Remove(Last);
        }
        public void Remove(Node<T>? node) {

            if (node == null) {
                return;
            }

            if (Count == 0) {
                return;
            } else if (Count == 1) {
                if (node == First) {
                    First = Last = null;
                    Count = 0;
                }
            } else {
                if (node == First) {
                    First = First.Next;
                    First!.Prev = null;
                } else if (node == Last) {
                    Last = Last.Prev;
                    Last.Next = null;
                } else {
                    node.Prev!.Next = node.Next;
                    node.Next!.Prev = node.Prev;
                }
                Count--;
            }

        }
        public void AddLast(Node<T> node) {

            if (Last == null) {
                Last = First = node;
                node.Next = node.Prev = null;
                Count = 1;
            } else {

                node.Next = null;
                node.Prev = Last;
                Last.Next = node;
                Last = node;
                Count++;
            }
        }

        public void AddLast(T value) {
            AddLast(new Node<T>(value));
        }

        public void Append(LinkedList<T> list) {
            if (Last == null) {
                First = list.First;
                Last = list.Last;
                Count = list.Count;
            } else {
                if (list.First != null) {
                    list.First.Prev = Last;
                    Last.Next = list.First;
                    Last = list.Last;
                    Count += list.Count;
                }
            }
        }
    }

    public static int PoisonousPlants2(List<int> p) {

        int max = 0;
        Stack<(int, int)> st = new();
        for (int i = 0, len = p.Count; i < len; i++) {
            int days = 0;
            while (st.Count > 0 && p[i] <= st.Peek().Item1) {
                days = Math.Max(days, st.Pop().Item2);
            }

            days = (st.Count == 0) ? 0 : days + 1;

            max = Math.Max(max, days);

            st.Push((p[i], days));
        }

        return max;
    }
}
