namespace LeetCode;
using static LeetCode.BinaryTreeTraversal;

public class BinaryTreeTraversalTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[]{
            TreeNode(2,3,4),
            new List<int>{2,3,4}
            };


        yield return new object[]{
            TreeNode(4,5,6),
            new List<int>{4,5,6}
        };

        yield return new object[]{
             TreeNode(2,3,4,4,5,6) ,
             new List<int>{2, 3, 4, 4, 5, 6 }
        };
    }
    [Theory]
    [MemberData(nameof(GetTestData))]
    public void InorderTraversalTrue(TreeNode root, List<int> expected)
    {
        BinaryTreeTraversal btt = new();
        IList<int> actual = btt.InorderTraversal(root);

        Assert.Equal(expected.ToArray(), actual.ToArray());
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
            if (values[i] < node.val)
            {
                node.left = new TreeNode(values[i]);
                node = node.left;

            }
            else
            {
                node.right = new TreeNode(values[i]);
                node = node.right;
            }
            i++;
        }


        return root;
    }

}