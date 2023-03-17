namespace LeetCode;

public class ValidateBinaryTree
{
    public bool IsValidBST(TreeNode root)
    {
        return IsValidBSTRecursive2(root, long.MinValue, long.MaxValue);
    }
    private bool IsValidBSTRecursive2(TreeNode? node, long min, long max)
    {
        if (node == null)
        {
            return true;
        }

        if (node.val <= min || node.val >= max)
        {
            return false;
        }

        return IsValidBSTRecursive2(node.left, min, node.val) &&
               IsValidBSTRecursive2(node.right, node.val, max);
    }
    private bool IsValidBSTRecursive1(TreeNode? node, TreeNode? prev)
    {
        //left
        if (node == null)
        {
            return true;
        }

        if (node.left != null && node.val <= node.left.val)
        {
            return false;
        }


        bool leftValid = IsValidBSTRecursive1(node.left, prev);

        if (prev != null && node.val <= prev.val)
        {
            return false;
        }

        //visit
        prev = node;

        //right
        bool rightValid = IsValidBSTRecursive1(node.right, prev);

        return leftValid && rightValid;
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