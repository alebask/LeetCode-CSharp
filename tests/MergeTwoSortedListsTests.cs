namespace LeetCode;
using static LeetCode.MergeTwoSortedLists;

public class MergeTwoSortedListsTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[]{
            LinkedList(2,3,4),
            LinkedList(4,5,6),
            LinkedList(2,3,4,4,5,6) };


        yield return new object[]{
            LinkedList(),
            LinkedList(0),
            LinkedList(0)
        };

        yield return new object[]{
            LinkedList(),
            LinkedList(),
            LinkedList()
        };
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void TestTrue(ListNode list1, ListNode list2, ListNode expected)
    {
        MergeTwoSortedLists mtsl = new();
        ListNode actual = mtsl.Execute(list1, list2);

        while (actual != null)
        {
            Assert.Equal(expected.val, actual.val);

            expected = expected.next;
            actual = actual.next;
        }
    }

    private static ListNode LinkedList(params int[] values)
    {
        ListNode result = null;

        for (int i = values.Length - 1; i >= 0; i--)
        {
            ListNode tmp = new()
            {
                val = values[i],
                next = result
            };

            result = tmp;

        }

        return result;
    }
}
