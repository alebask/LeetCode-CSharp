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
                n = tmp;
                j = n;

            }
        }

        int l = 1;
        int lmax = 1;
        for (int i = 0, length = nums.Length; i < length; i++) {
            l = (nums[i] == i) ? l + 1 : 1;
            lmax = Math.Max(lmax, l);
        }
        return l;
    }
}