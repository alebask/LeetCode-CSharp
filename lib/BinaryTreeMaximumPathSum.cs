namespace LeetCode;

public class BinaryTreeMaximumPathSum {

    public int MaxPathSum(TreeNode root) {

        int max = int.MinValue;
        MaxPathSum(root, ref max);

        return max;
    }

    public int MaxPathSum(TreeNode? node, ref int max) {

        if (node == null) {
            return 0;
        }


        int left = MaxPathSum(node.left, ref max);
        int right = MaxPathSum(node.right, ref max);

        max = Math.Max(left + right + node.val, max);
        max = Math.Max(left + node.val, max);
        max = Math.Max(right + node.val, max);
        max = Math.Max(node.val, max);

        return Math.Max(node.val, Math.Max(left, right) + node.val);
    }




    public class TreeNode {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}

