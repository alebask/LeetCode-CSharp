using System.Numerics;

namespace LeetCode;

public class ReverseInteger
{
    public int Reverse(int x)
    {
        int n = x;
        int result = 0;

        while (n != 0)
        {
            unchecked
            {
                int tail = n % 10;
                int tmp = result * 10 + tail;

                if (tmp / 10 != result)
                    return 0;

                result = tmp;
                n /= 10;
            }
        }

        return result;
    }
}