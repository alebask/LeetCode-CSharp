using LeetCode;
using static LeetCode.AddTwoNumbers;

namespace LeetCode
{
    public class AddTwoNumbersTests
    {

        //tests
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void AddTwoNumbersTestTrue(ListNode l1, ListNode l2, ListNode expected)
        {
            AddTwoNumbers atn = new();
            ListNode actual = atn.Execute(l1, l2);

            while (actual.next != null)
            {
                Assert.Equal(expected.val, actual.val);

                expected = expected.next;
                actual = actual.next;
            }
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[]{
            LinkedList(2,4,3),
            LinkedList(5,6,4),
            LinkedList(7,0,8) };

            yield return new object[]{
            LinkedList(9,9,9,9,9,9,9),
            LinkedList(9,9,9,9),
            LinkedList(8,9,9,9,0,0,0,1)
        };
        }

        private static ListNode LinkedList(params int[] values)
        {
            ListNode result = new(values[0]);

            if (values.Length > 1)
            {
                ListNode node = result;
                for (int i = 1; i < values.Length; i++)
                {
                    ListNode next = new(values[i]);
                    node.next = next;
                    node = next;
                }
            }

            return result;
        }
    }
}