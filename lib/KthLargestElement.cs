namespace LeetCode;
using System.Collections.Generic;

public class KthLargestElement
{
    public int FindKthLargestQuickSort(int[] nums, int k)
    {
        k = nums.Length - k;
        Random rand = new Random(k);

        return QuickSelect(nums, 0, nums.Length - 1, k, rand);
    }
    private int QuickSelect(int[] nums, int left, int right, int k, Random rand)
    {
        int pind = rand.Next(left, right);
        int pval = nums[pind];

        (nums[right], nums[pind]) = (nums[pind], nums[right]);

        pind = left;
        for (int i = left; i < right; i++)
        {
            if (nums[i] < pval)
            {
                (nums[i], nums[pind]) = (nums[pind], nums[i]);
                pind++;
            }
        }

        (nums[right], nums[pind]) = (nums[pind], nums[right]);

        if (pind > k)
        {
            return QuickSelect(nums, left, pind - 1, k, rand);
        }
        else if (pind < k)
        {
            return QuickSelect(nums, pind + 1, right, k, rand);
        }

        return nums[pind];
    }


    public int FindKthLargestWithLinq(int[] nums, int k)
    {
        return nums.OrderBy(x => x).ElementAt(nums.Length - k);
    }

    public int FindKthLargestWithQueue(int[] nums, int k)
    {
        PriorityQueue<int, int> q = new(nums.Length);

        for (int i = 0, l = nums.Length; i < l; i++)
        {
            q.Enqueue(nums[i], nums[i]);
        }

        for (int j = 0, l = nums.Length - k; j < l; j++)
        {
            q.Dequeue();
        }

        return q.Dequeue();
    }

    public class DuplicateKeyComparer<TKey> : IComparer<TKey> where TKey : IComparable
    {
        public int Compare(TKey? x, TKey? y)
        {
            int result = x!.CompareTo(y);

            if (result == 0)
                return 1;
            else
                return result;
        }
    }
}
