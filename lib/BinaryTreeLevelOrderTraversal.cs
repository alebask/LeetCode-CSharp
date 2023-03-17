namespace LeetCode;

public class BinaryTreeLevelOrderTraversal
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();

        LevelOrderRecursive(root, 0, ref result);

        return result;
    }

    public void LevelOrderRecursive(TreeNode? root, int level, ref IList<IList<int>> result)
    {
        if (root == null)
        {
            return;
        }

        if (level > result.Count - 1)
        {
            result.Add(new List<int>() { root.val });
        }
        else
        {
            result[level].Add(root.val);
        }

        LevelOrderRecursive(root.left, level + 1, ref result);
        LevelOrderRecursive(root.right, level + 1, ref result);
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