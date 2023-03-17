namespace LeetCode;
using static LeetCode.ValidateBinaryTree;

public class ValidateBinaryTreeTests
{
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void ExecuteTests(TreeNode root, bool expected)
    {
        ValidateBinaryTree vbt = new();
        bool actual = vbt.IsValidBST(root);
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> GetTestData()
    {

        yield return new object[]{
            TreeNode(2,2,2), false
        };

        yield return new object[]{
            TreeNode(1,1), false
        };
    }

    private static TreeNode TreeNode(params int[] values)
    {
        //root, left right

        if (values.Length == 0) return null;

        TreeNode node = new(values[0]);
        TreeNode root = node;
        int i = 1;
        while (i < values.Length)
        {
            if (i % 2 != 0)
            {
                node.left = new TreeNode(values[i]);
            }
            else
            {
                node.right = new TreeNode(values[i]);
            }
            i++;


        }

        return root;
    }
}