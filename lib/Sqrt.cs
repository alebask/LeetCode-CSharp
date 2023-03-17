namespace LeetCode;

public class Sqrt
{
    public int Execute(int x)
    {
        if (x == 0) return x;

        int left = 1, right = x;

        while (right - left > 1)
        {
            int half = left + (right - left) / 2;
            if (half > x / half)
            {
                right = half;
            }
            else
            {
                left = half;
            }
        }

        return left;
    }
}