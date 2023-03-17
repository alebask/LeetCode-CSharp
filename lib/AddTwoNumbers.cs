namespace LeetCode
{
    public class AddTwoNumbers
    {
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

        public ListNode? Execute(ListNode l1, ListNode l2)
        {
            ListNode? result = ExecuteRecursive(l1, l2, 0);
            return result;
        }

        private ListNode? ExecuteRecursive(ListNode? l1, ListNode? l2, int digit)
        {
            if (l1 == null && l2 == null && digit == 0)
            {
                return null;
            }

            ListNode result = new(digit);

            if (l1 is not null)
            {
                result.val += l1.val;
                l1 = l1.next;
            }

            if (l2 is not null)
            {
                result.val += l2.val;
                l2 = l2.next;
            }

            if (result.val / 10 == 1)
            {
                result.val %= 10;
                digit = 1;
            }
            else
            {
                digit = 0;
            }

            result.next = ExecuteRecursive(l1, l2, digit);

            return result;

        }
    }
}