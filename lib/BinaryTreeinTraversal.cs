namespace LeetCode;

public class BinaryTreeTraversal
{

    public IList<int> InorderTraversal(TreeNode? root)
    {
        List<int> result = new();
        Stack<TreeNode> stack = new();

        TreeNode? node = root;

        while (stack.Count > 0 || node != null)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }

            node = stack.Pop();
            result.Add(node.val);
            node = node.right;
        }

        return result;
    }

    private void InorderTraversalRecursive(TreeNode? root, IList<int> list)
    {

        //left-root-right
        if (root != null)
        {
            InorderTraversalRecursive(root.left, list);
            list.Add(root.val);
            InorderTraversalRecursive(root.right, list);
        }

    }



    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}