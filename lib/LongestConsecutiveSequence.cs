namespace LeetCode;

public class LongestConsecutiveSequence {
    public int LongestConsecutive(int[] nums) {

        if (nums.Length == 0) {
            return 0;
        }

        for (int i = 0, length = nums.Length; i < length; i++) {

            int n = nums[i];
            int j = i;
            while (n != j && n < length) {
                int tmp = nums[n];
                nums[n] = n;
                j = n;
                n = tmp;
            }
        }

        int l = 0;
        int lmax = 0;
        for (int i = 0, length = nums.Length; i < length; i++) {
            l = (nums[i] == i) ? l + 1 : 0;
            lmax = Math.Max(lmax, l);
        }
        return lmax;
    }
}