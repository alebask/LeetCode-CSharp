namespace LeetCode
{
    public class TwoSum
    {
        public static int[] ExecuteWithDictionary(int[] nums, int target)
        {

            Dictionary<int, int> d = new(nums.Length);
            int[] result = new int[2];


            for (int i = 0; i < nums.Length; i++)
            {
                int num1 = nums[i];
                int num2 = target - num1;

                if (d.ContainsKey(num2))
                {
                    result[0] = d[num2];
                    result[1] = i;
                    return result;
                }

                d.TryAdd(num1, i);
            }

            return result;
        }

        public static int[] ExecuteWithSort(int[] nums, int target)
        {
            Array.Sort(nums);

            int start = 0;
            int end = nums.Length - 1;

            while (start < end)
            {
                int sum = nums[start] + nums[end];

                if (sum == target)
                {
                    return new int[] { start, end };
                }
                else if (sum < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return Array.Empty<int>();
        }
    }

}