namespace LeetCode;

public class MergeKSortedLists
{
    //0 1 2 3 4 5 6
    public ListNode? Merge(ListNode?[] lists)
    {
        if (lists.Length == 0) return null;
        if (lists.Length == 1) return lists[0];

        int last = lists.Length - 1;

        while (last > 0)
        {
            int first = 0;
            while (first < last)
            {
                lists[first] = Merge2SortedLists(lists[first], lists[last]);
                first++;
                last--;
            }
        }

        return lists[last]; //lists[0]
    }

    private ListNode? Merge2SortedLists(ListNode? n1, ListNode? n2)
    {
        if (n1 == null && n2 == null) return null;
        if (n1 != null && n2 == null) return n1;
        if (n2 == null && n2 != null) return n2;

        ListNode? result;

        if (n1!.val <= n2!.val)
        {
            result = n1;
            result.next = Merge2SortedLists(n1.next, n2);

        }
        else
        {
            result = n2;
            result.next = Merge2SortedLists(n1, n2.next);
        }

        return result;
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}