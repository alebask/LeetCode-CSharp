namespace LeetCode;

public class Permutations
{
    public int[][] Permute(int[] nums)
    {
        List<int[]> result = new();

        DoPermutations(nums, 0, result);

        return result.ToArray();
    }

    private void DoPermutations(int[] nums, int index, List<int[]> result)
    {
        if (index == nums.Length - 1)
        {
            int[] tmp = new int[nums.Length];
            Array.Copy(nums, tmp, nums.Length);
            result.Add(tmp);
        }
        else
        {
            for (int i = index; i < nums.Length; i++)
            {

                (nums[i], nums[index]) = (nums[index], nums[i]);
                DoPermutations(nums, index + 1, result);
                (nums[i], nums[index]) = (nums[index], nums[i]);
            }
        }
    }

    public IList<IList<int>> PermuteLINQ(int[] nums)
    {
        return GetPermutations(nums, nums.Length).Select(x => x.ToArray()).ToArray();
    }

    private IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> set, int len)
    {
        if (len == 1) return set.Select(t => new T[] { t });
        return GetPermutations(set, len - 1)
          .SelectMany(t => set.Where(o => !t.Contains(o)),
            (t1, t2) => t1.Concat(new T[] { t2 }));
    }
}

