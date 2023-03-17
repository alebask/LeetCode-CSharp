namespace LeetCode;

public class RemoveNthNodeFromEndofList
{

    public ListNode? RemoveNthFromEnd(ListNode? head, int n)
    {
        if (head == null) return null;
        if (head.next == null & n == 1) return null;

        ListNode? node1 = head;
        ListNode? node2 = head;

        int i = 1;
        while (node1.next != null)
        {
            node1 = node1.next;

            if (i > n)
            {
                node2 = node2?.next;
            }

            i++;
        }

        if (i == n) //node2 is head
            head = head.next;

        node2!.next = node2?.next?.next;

        return head;
    }

    //[1,2,3], n = 1


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