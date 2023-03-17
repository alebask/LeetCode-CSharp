namespace LeetCode;

public class HouseRobber {

    public int Rob3(int[] nums) {

        int total = 0;
        int prev1 = 0;
        int prev2 = 0;

        for (int i = 0, l = nums.Length; i < l; i++) {
            total = Math.Max(prev1, prev2 + nums[i]);
            prev2 = prev1;
            prev1 = total;
        }

        return total;
    }

    public int Rob2(int[] nums) {

        int even = 0;
        int odd = 0;

        for (int i = 0, l = nums.Length; i < l; i++) {
            if (i % 2 == 0) {
                even = Math.Max(even + nums[i], odd);
            } else {
                odd = Math.Max(even, odd + nums[i]);
            }
        }

        return Math.Max(even, odd);
    }
    public int Rob1(int[] nums) {

        int[] memo = new int[100];
        int length = nums.Length;

        int total = RobR(nums, 0, length, memo);

        return total;
    }

    public int RobR(int[] nums, int i, int length, int[] memo) {

        if (i > length) {
            return 0;
        }

        if (memo[i] != 0) {
            return memo[i];
        }

        int total1 = i + RobR(nums, i + 1, length, memo);
        int total2 = i + RobR(nums, i + 2, length, memo);

        return Math.Max(total1, total2);
    }

}