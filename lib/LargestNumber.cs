
using System.Text;

namespace LeetCode;

public class LargestNumber
{
    public string ExecuteLINQ(int[] nums)
    {
        return nums.Select(x => x.ToString())
               .OrderBy(s => s, Comparer<string>.Create((s1, s2) => (s2 + s1).CompareTo(s1 + s2)))
               .Aggregate((s1, s2) => (s1 == "0") ? "0" : $"{s1}{s2}");
    }
    //Input: nums = [3,30,34,5,9]
    //Output: "9534330"
    public string Execute(int[] nums)
    {
        PriorityQueue<bool, string> pq = new(nums.Length, new DigitOrderStringComparer());

        for (int i = 0, l = nums.Length; i < l; i++)
        {
            pq.Enqueue(true, nums[i].ToString());
        }

        StringBuilder sb = new();
        while (pq.TryDequeue(out _, out string? n))
        {
            sb.Append(n);
        }


        return (sb[0] == '0') ? "0" : sb.ToString();
    }

    public class DigitOrderStringComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return (y + x).CompareTo(x + y);
        }
    }
}