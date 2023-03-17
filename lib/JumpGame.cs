namespace LeetCode;

public class JumpGame {

    public bool CanJump(int[] nums) {

        int max = 0;
        for (int i = 0, l = nums.Length; i < l; i++) {

            if (i > max) {
                return false;
            }
            max = Math.Max(nums[i] + i, max);
        }

        return true;

    }

    public bool CanJump2(int[] nums) {

        if (nums.Length < 2) {
            return true;
        }

        int i = nums.Length - 2;
        while (i >= 0) {
            if (nums[i] == 0) {
                int minJump = 1;
                while (i >= 0 && nums[i] < minJump) {
                    minJump++;
                    i--;
                }
                if (i < 0) {
                    return false;
                }
            }
            i--;
        }

        return true;

    }
}

