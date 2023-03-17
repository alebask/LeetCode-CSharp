namespace LeetCode;

public class CopyListRandomPointer {
    public Node? CopyRandomList(Node head) {


        if (head == null) {
            return null;
        }

        Dictionary<Node, Node> map = new();

        Node n = head;
        Node dummy = new(0);
        while (n != null) {

            Node nn = new Node(n.val);
            nn.random = n.random;
            dummy.next = nn;

            map.Add(n, nn);

            n = n.next!;
            dummy = nn;
        }

        n = map[head];
        while (n != null) {
            if (n.random != null) {
                n.random = map[n.random!];
            }
            n = n.next!;
        }

        return map[head];
    }


    public class Node {
        public int val;
        public Node? next;
        public Node? random;

        public Node(int _val) {
            val = _val;
            next = null;
            random = null;
        }
    }
}