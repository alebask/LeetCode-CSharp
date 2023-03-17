namespace LeetCode;

public class MaxMinHackerRankSolition {

    public static int MaxMin(int k, List<int> arr) {

        arr.Sort();

        int result = int.MaxValue;
       
        int n = arr.Count;
        int i = 0;
        int j = k - 1;

        while (j < n) {
            result = Math.Min(result, arr[j] - arr[i]);
            j++;
            i++;
        }
        return result;
    }
}