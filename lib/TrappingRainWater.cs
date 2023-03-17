namespace LeetCode;

public class TrappingRainWater {
    public int Trap(int[] height) {

        int n = height.Length;

        if (n < 3) {
            return 0;
        }

        int result = 0;

        Stack<int> st = new();
        st.Push(0);

        for (int i = 1; i < n; i++) {
            while (st.Count > 0 && height[st.Peek()] < height[i]) {
                int pop = st.Pop();
                if (st.Count > 0) {
                    int dh = Math.Min(height[st.Peek()], height[i]) - height[pop];
                    int dw = i - 1 - st.Peek();
                    result += dh * dw;
                }
            }
            st.Push(i);
        }

        return result;
    }
}