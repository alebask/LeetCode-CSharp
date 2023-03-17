namespace LeetCode;

public class SearchRotatedSortedArray
{

    public int Search2(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length;

        while (start < end)
        {
            int mid = (start + end) / 2;
            int n = nums[mid];

            if (target == n)
            {
                return mid;
            }
            else if (target >= nums[0] && n >= nums[0])
            {
                if (target > n) start = mid + 1;
                else end = mid;
            }
            else if (target >= nums[0] && n < nums[0])
            {
                end = mid;
            }
            else if (target < nums[0] && n >= nums[0])
            {
                start = mid + 1;
            }
            else if (target < nums[0] && n < nums[0])
            {
                if (target > n) start = mid + 1;
                else end = mid;
            }

        }

        return -1;
    }

    public int Search1(int[] nums, int target)
    {
        if (nums.Length == 1) return (nums[0] == target) ? 0 : -1;

        int start = 0;
        int end = nums.Length - 1;

        while (start < end)
        {
            int mid = (end + start) / 2;

            if (nums[mid] >= nums[0])
            {
                start = mid;

                if (nums[mid + 1] < nums[mid])
                {
                    break;
                }
                else
                {
                    start++;
                }
            }
            else
            {
                end = mid;
            }
        }

        //nums[start] == max value here        
        if (target >= nums[0])
        {
            end = start;
            start = 0;
        }
        else
        {
            end = nums.Length - 1;
            if (start < end) start++;
        }

        while (start < end)
        {
            int mid = (end + start) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return (nums[start] == target) ? start : -1;
    }
}