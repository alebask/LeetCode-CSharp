namespace LeetCode;
public class MaximumProductSubarray {
    public int MaxProduct(int[] nums) {


        int pmax = nums[0];
        int p = 1;

        for (int i = 0, l = nums.Length; i < l; i++) {

            p *= (p == 0) ? 1 : nums[i];
            pmax = Math.Max(pmax, p);

        }

        p = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {

            p *= (p == 0) ? 1 : nums[i];
            pmax = Math.Max(pmax, p);
        }


        return pmax;
    }
}