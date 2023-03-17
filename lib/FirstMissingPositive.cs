namespace LeetCode;

public class FirstMissingPositive {

    public int Execute2(int[] nums) {

        if (nums.Length == 0) {
            return 0;
        }

        HashSet<int> hs = new();

        foreach (int n in nums) {
            if (!hs.Contains(n))
                hs.Add(n);
        }

        int result = 1;

        foreach (int item in hs) {

            int n = item;
            int count = 1;

            while (hs.Contains(--n)) {
                count++;
                hs.Remove(n);
            }

            n = item;
            while (hs.Contains(++n)) {
                count++;
                hs.Remove(n);
            }
            result = Math.Max(result, count);
            hs.Remove(item);
        }

        return result;
    }

    public int Execute1(int[] nums) {

        if (nums.Length == 0) {
            return 0;
        }

        Dictionary<int, int> dict = new();

        foreach (int n in nums) {
            dict.TryAdd(n, 1);
        }

        int result = 1;
        foreach (var item in dict) {
            int n = item.Key;
            if (!dict.ContainsKey(n - 1)) {
                while (dict.ContainsKey(++n)) ;
                result = Math.Max(result, n - item.Key);
            }
        }

        return result;
    }


    public int ExecuteSimple(int[] nums) {

        if (nums.Length == 0) {
            return 0;
        }

        Array.Sort(nums);

        int lmax = 1;
        int l = 1;

        for (int i = 0, il = nums.Length - 1; i < il; i++) {
            if (nums[i + 1] == nums[i] + 1) {
                l++;
            } else if (nums[i + 1] == nums[i]) {
                continue;
            } else {
                l = 1;
            }

            lmax = Math.Max(lmax, l);
        }

        return lmax;
    }

    public int Execute(int[] nums) {

        int len = nums.Length;

        for (int i = 0; i < len; i++) {
            while (nums[i] >= 1 && nums[i] <= len && nums[i] != nums[nums[i] - 1]) {
                (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);
            }
        }

        for (int i = 0; i < len; i++) {
            if (nums[i] != i + 1) {
                return i + 1;
            }
        }

        return len + 1;
    }

}