namespace LeetCode;

public class FirstLastPositions
{
    public int[] SearchRange2(int[] nums, int target)
    {
        if (nums.Length == 0) return new int[] { -1, -1 };
        if (nums.Length == 1) return (nums[0] == target) ? new int[] { 0, 0 } : new int[] { -1, -1 };
        if (target < nums[0] || target > nums[^1]) return new int[] { -1, -1 };

        int left = -1, right = -1;

        int i = 0;
        int j = nums.Length - 1;

        while (i <= j)
        {
            int mid = i + (j - i) / 2;

            if (nums[mid] < target)
                i = mid + 1;
            else
                j = mid - 1;

            if (nums[mid] == target) left = mid;
        }

        i = 0;
        j = nums.Length - 1;


        while (i <= j)
        {
            int mid = i + (j - i) / 2;

            if (nums[mid] <= target)
                i = mid + 1;
            else
                j = mid - 1;

            if (nums[mid] == target) right = mid;
        }

        return new int[] { left, right };
    }

    public int[] SearchRange1(int[] nums, int target)
    {
        if (nums.Length == 0) return new int[] { -1, -1 };
        if (nums.Length == 1) return (nums[0] == target) ? new int[] { 0, 0 } : new int[] { -1, -1 };
        if (target < nums[0] || target > nums[^1]) return new int[] { -1, -1 };

        int left = 0;
        int right = nums.Length - 1;


        while (right - left > 1)
        {

            int mid = left + (right - left) / 2;

            if (nums[mid] <= target)
            {
                left = mid;
            }
            else
            {
                right = mid;
            }
        }

        if (nums[left] == target || nums[right] == target)
        {
            (left, right) = (nums[left] == target) ? (left, left) : (right, right);

            while (left - 1 >= 0 && nums[left - 1] == target) { left--; };
            while (right + 1 < nums.Length && nums[right + 1] == target) { right++; };

            return new int[] { left, right };
        }

        return new int[] { -1, -1 };
    }
}