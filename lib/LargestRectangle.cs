namespace LeetCode;

public class LargestRectangle {
    public int LargestRectangleArea(int[] heights) {

        if (heights.Length == 1) {
            return heights[0];
        }

        int max = 0;

        Stack<int> st = new();

        int len = heights.Length;
        for (int i = 0; i < len; i++) {

            int h = heights[i];

            while (st.Count > 0 && heights[st.Peek()] > h) {
                int top = st.Pop();
                int width = (st.Count == 0) ? i : i - st.Peek() - 1;
                max = Math.Max(max, heights[top] * width);
            }

            st.Push(i);

        }

        while (st.Count > 0) {
            int top = st.Pop();
            int width = (st.Count == 0) ? len : len - st.Peek() - 1;
            max = Math.Max(max, heights[top] * width);
        }

        return max;
    }
}