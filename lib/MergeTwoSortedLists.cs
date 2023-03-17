namespace LeetCode;

public class MergeTwoSortedLists
{

    public ListNode? Execute(ListNode? list1, ListNode? list2)
    {
        ListNode ptr0 = new();
        ListNode ptr = ptr0;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                ptr.next = list1;
                list1 = list1.next;
            }
            else
            {
                ptr.next = list2;
                list2 = list2.next;
            }

            ptr = ptr.next;
        }

        ptr.next = list1 ?? list2;

        return ptr0.next;
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




