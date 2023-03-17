namespace LeetCode;

public class FraudulentActivityNotifications {
    public static int ActivityNotifications(List<int> expenditure, int d) {

        int[] counts = new int[201];

        for (int i = 0; i < d; i++) {
            counts[expenditure[i]]++;
        }

        int result = 0;

        for (int i = d, len = expenditure.Count; i < len; i++) {

            int doubleMedian = GetDoubleMedian(counts, d);

            if (expenditure[i] >= doubleMedian) {
                result++;
            }

            counts[expenditure[i]]++;
            counts[expenditure[i - d]]--;
        }

        return result;
    }

    private static int GetDoubleMedian(int[] counts, int d) {

        bool even = (d % 2 == 0);
        int count = 0;

        if (even) {
            int target = d / 2;
            for (int i = 0, len = counts.Length; i < len; i++) {
                if (counts[i] > 0) {
                    count += counts[i];
                }
                if (count > target) {
                    return 2 * i;
                } else if (target == count) {
                    for (int j = i + 1; j < len; j++) {
                        if (counts[j] > 0) {
                            return i + j;
                        }
                    }
                }
            }
        } else {
            int target = d / 2 + 1;
            for (int i = 0, len = counts.Length; i < len; i++) {
                if (counts[i] > 0) {
                    count += counts[i];
                }
                if (count >= target) {
                    return 2 * i;
                }
            }
        }

        return -1; //fake return, never happens
    }
}