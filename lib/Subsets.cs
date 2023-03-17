namespace LeetCode;

public class Subsets {

    public IList<IList<int>> Generate(int[] nums) {

        List<IList<int>> result = new() { new List<int>() };

        for (int i = 0, ln = nums.Length; i < ln; i++) {
            for (int j = 0, lr = result.Count; j < lr; j++) {
                result.Add(new List<int>(result[j]) { nums[i] });
            }
        }

        return result;
    }

}