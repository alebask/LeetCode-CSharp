namespace LeetCode;

public class RemoveDuplicatesFromSortedArray
{
    public int Execute(int[] nums)
    {
        int len = nums.Length;

        if (len < 2) return len;

        int pos = 0;
        for (int i = pos; i < len - 1; i++)
        {
            if (nums[i + 1] > nums[i])
            {
                pos++;
                nums[pos] = nums[i + 1];
            }
        }

        return pos + 1;
    }

}
