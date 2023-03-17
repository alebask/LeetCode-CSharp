namespace LeetCode;

public class MergeIntervals {

    public int[][] Merge(int[][] intervals) {

        QuickSort(intervals, 0, intervals.Length - 1);

        List<int[]> result = new();
        result.Add(intervals[0]);

        for (int i = 1, l = intervals.Length; i < l; i++) {

            int[] prev = result[^1];
            int[] curr = intervals[i];

            if (prev[1] < curr[0]) {
                result.Add(curr);
            } else {
                prev[1] = Math.Max(prev[1], curr[1]);
            }
        }

        return result.ToArray();
    }

    private void QuickSort(int[][] intervals, int left, int right) {
        if (left < right) {
            int pivot = Partition(intervals, left, right);
            QuickSort(intervals, left, pivot - 1);
            QuickSort(intervals, pivot + 1, right);
        }
    }
    private int Partition(int[][] intervals, int left, int right) {

        int pIndex = left;
        int pValue = intervals[right][0];

        for (int j = left; j <= right; j++) {
            if (intervals[j][0] < pValue) {
                (intervals[pIndex], intervals[j]) = (intervals[j], intervals[pIndex]);
                pIndex++;
            }
        }
        (intervals[right], intervals[pIndex]) = (intervals[pIndex], intervals[right]);

        return pIndex;
    }
}
