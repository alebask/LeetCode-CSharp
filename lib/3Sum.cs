namespace LeetCode;

public class ThreeSum
{
    public static int[][] Execute2(int[] nums)
    {

        List<int[]> triplets = new();

        Array.Sort(nums);

        int target = 0;

        while (target < nums.Length)
        {
            int start = target + 1;
            int end = nums.Length - 1;

            while (start < end)
            {
                int sum = nums[target] + nums[start] + nums[end];
                if (sum == 0)
                {
                    triplets.Add(new int[] { nums[target], nums[start], nums[end] });
                    start++;
                    end--;

                    while (start < end && nums[start] == nums[start - 1]) { start++; }
                    while (start < end && nums[end] == nums[end + 1]) { end--; }
                }
                else if (sum < 0)
                {
                    start++;
                    while (start < end && nums[start] == nums[start - 1]) { start++; }
                }
                else
                {
                    end--;
                    while (start < end && nums[end] == nums[end + 1]) { end--; }
                }
            }

            target++;

            while (target < nums.Length && nums[target] == nums[target - 1]) { target++; }

        }


        return triplets.ToArray();
    }

    public static int[][] Execute1(int[] nums)
    {
        Dictionary<(int, int), int[]> triplets = new();

        for (int i = 0; i < nums.Length; i++)
        {
            Dictionary<int, int> d = new();

            int target = nums[i];

            for (int j = i + 1; j < nums.Length; j++)
            {
                int num1 = nums[j];
                int num2 = -target - num1;

                if (d.ContainsKey(num2))
                {
                    int min = Math.Min(Math.Min(target, num1), num2);
                    int max = Math.Max(Math.Max(target, num1), num2);

                    if (!triplets.ContainsKey((min, max)))
                    {
                        var item = new int[] { min, -min - max, max };
                        triplets.Add((min, max), item);
                    }
                }

                d.TryAdd(num1, j);
            }
        }

        return triplets.Values.ToArray();
    }
}