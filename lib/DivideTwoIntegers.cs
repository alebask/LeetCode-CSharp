namespace LeetCode;

public class DidivdeTwoIntegers
{

    public int Divide(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException();
        }
        if (divisor == 1)
        {
            return dividend;
        }
        if (divisor == -1)
        {
            if (dividend == int.MinValue) return int.MaxValue;
            return -dividend;
        }
        if (divisor == int.MinValue)
        {
            return (dividend == int.MinValue) ? 1 : 0;
        }

        bool negative = (dividend < 0 && divisor > 0 || dividend > 0 && divisor < 0);

        (int n, int r) = (dividend == int.MinValue) ? (int.MaxValue, 1) : (Math.Abs(dividend), 0);
        int d = Math.Abs(divisor);

        int result = 0;


        while (n >= d)
        {
            int i = 1;
            while (n >> i > d) { i++; }
            n -= d << (i - 1);
            result += 1 << (i - 1);
        }
        if (n + r == d) result++;

        return (negative) ? -result : result;
    }
}