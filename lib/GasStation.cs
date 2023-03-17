namespace LeetCode;

public class GasStation {
    public int CanCompleteCircuit(int[] gas, int[] cost) {

        int sum = 0, im = 0, m = 0;

        for (int i = 0, n = gas.Length; i < n; i++) {
            m += gas[i] - cost[i];
            if (m < 0) {
                sum += m;
                m = 0;
                im = i + 1;
            }
        }
        sum += m;

        if (sum < 0) {
            return -1;
        }

        return im;
    }
}