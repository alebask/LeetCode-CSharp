namespace LeetCode;

public class ListSorting {

    public ListNode SortList(ListNode? head) {

        if (head == null || head.next == null) {
            return head!;
        }

        ListNode n = head;
        ListNode mid = head;

        while (n.next != null) {
            n = n.next;
            if (n.next != null) {
                n = n.next;
                mid = mid.next!;
            }
        }

        ListNode left = head;
        ListNode right = mid.next!;
        mid.next = null;

        left = SortList(left);
        right = SortList(right);

        ListNode result = new();
        n = result;
        while (left != null && right != null) {
            if (left.val <= right.val) {
                n.next = left;
                left = left.next!;
            } else {
                n.next = right;
                right = right.next!;
            }
            n = n.next;
        }
        while (left != null) {
            n.next = left;
            left = left.next!;
            n = n.next;
        }
        while (right != null) {
            n.next = right;
            right = right.next!;
            n = n.next;
        }
        return result.next!;
    }


    public class ListNode {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null) {
            this.val = val;
            this.next = next;
        }

    }
}