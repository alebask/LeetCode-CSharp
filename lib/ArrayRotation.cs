namespace LeetCode;

public class ArrayRotation
{
    public void Rotate1(int[] nums, int k)
    {
        int n = nums.Length;
        k = k % n;

        if (k == 0) return;
        if (n == 1) return;

        RotateRecursive(nums, 0, n - 1, k);
    }

    public void Rotate2(int[] nums, int k)
    {
        int n = nums.Length;
        k %= n;

        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
    }

    public void Rotate3(int[] nums, int k)
    {
        int n = nums.Length;
        k %= n;
        k = n - k;

        nums.Skip(k).Concat(nums.Take(k))
        .Select((v, i) => new { index = i, value = v }).ToList()
        .ForEach(x => { nums[x.index] = x.value; });
    }

    private void Reverse(int[] nums, int left, int right)
    {
        while (left < right)
        {
            (nums[left], nums[right]) = (nums[right], nums[left]);
            left++;
            right--;
        }
    }

    private void RotateRecursive(int[] nums, int l, int r, int k)
    {
        int n = r - l + 1;

        if (n == 1)
        {
            return;
        }

        if (2 * k <= n)
        {
            for (int i = r, j = r - k; i > j; i--)
            {
                (nums[i], nums[i - k]) = (nums[i - k], nums[i]);
            }

            if (2 * k != n)
            {
                RotateRecursive(nums, l, r - k, k);
            }
        }
        else if (2 * k > n)
        {
            for (int i = l, m = n - k, j = l + m; i < j; i++)
            {
                (nums[i], nums[m + i]) = (nums[m + i], nums[i]);
            }
            RotateRecursive(nums, l + n - k, r, 2 * k - n);
        }

    }
}