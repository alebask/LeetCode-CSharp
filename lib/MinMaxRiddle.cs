namespace LeetCode;

public class MinMaxRiddle {
    static long[] riddle1(long[] arr) {
        // complete this function
        int n = arr.Length;
        long[] result = new long[n];

        for (int len = 1; len <= n; len++) {
            long max = long.MinValue;
            int shift = 0;
            while (shift + len <= n) {
                long min = long.MaxValue;
                for (int i = shift; i < len + shift; i++) {
                    min = Math.Min(min, arr[i]);
                }
                max = Math.Max(max, min);
                shift++;
            }
            result[len - 1] = max;
        }
        return result;
    }

    static long[] riddle2(long[] arr) {
        // complete this function
        int n = arr.Length;
        long[] result = new long[n];
        for (int i = 0, l = result.Length; i < l; i++) {
            result[i] = -1;
        }

        Stack<int> st = new();

        for (int i = 0; i < n; i++) {

            while (st.Count > 0 && arr[st.Peek()] > arr[i]) {
                int index = st.Pop();
                int width = (st.Count > 0) ? i - 1 - st.Peek() : i;
                result[width - 1] = Math.Max(result[width - 1], arr[index]);
            }

            st.Push(i);
        }
        while (st.Count > 0) {
            int index = st.Pop();
            int width = (st.Count > 0) ? n - 1 - st.Peek() : n;
            result[width - 1] = Math.Max(result[width - 1], arr[index]);
        }

        for (int i = n - 1; i > 0; i--) {
            result[i] = Math.Max(result[i], result[i + 1]);
        }

        return result;
    }
}