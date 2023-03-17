namespace LeetCode;

public class MaximumSubarray
{

    public int FindMax(int[] nums)
    {
        int result = int.MinValue;
        int sum = 0;

        for (int i = 0, len = nums.Length; i < len; i++)
        {
            sum += nums[i];

            if (sum > result)
            {
                result = sum;
            }
            if (sum < 0)
            {
                sum = 0;
            }
        };

        return result;
    }
}