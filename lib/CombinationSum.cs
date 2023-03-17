namespace LeetCode;

public class CombinationSumSolution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {

        Array.Sort(candidates);

        List<IList<int>> result = new();
        LinkedList<int> seed = new();

        CombinationSum(candidates, target, 0, candidates.Length, result, seed);

        return result;
    }

    public void CombinationSum(int[] sorted, int target, int index, int len, List<IList<int>> result, LinkedList<int> seed) {

        if (target == 0) {
            int[] tmp = new int[seed.Count];
            seed.CopyTo(tmp, 0);
            result.Add(tmp);
            return;
        }

        while (index < len && sorted[index] <= target) {
            seed.AddLast(sorted[index]);
            CombinationSum(sorted, target - sorted[index], index, len, result, seed);
            seed.RemoveLast();
            index++;
        }
    }
}

