namespace LeetCode;

public class PopulateNextRightPointers
{

    public Node Connect(Node root)
    {
        Recursive(root);

        return root;
    }
    public void Iterative(Node? root)
    {

        Node? v = root;
        while (v != null)
        {

            Node h = v;
            while (h != null)
            {
                if (h.left != null)
                {
                    h.left.next = h.right;
                }
                if (h.right != null && h.next != null)
                {
                    h.right.next = h.next.left;
                }
            }

            v = v.left;
        }
    }
    public void Recursive(Node? root)
    {
        if (root == null)
        {
            return;
        }

        if (root.left != null)
        {
            root.left.next = root.right;
        }
        if (root.right != null && root.next != null)
        {
            root.right.next = root.next.left;
        }

        Recursive(root.left);
        Recursive(root.right);

    }


    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node? left;
        public Node? right;
        public Node? next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node? _left, Node? _right, Node? _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

}