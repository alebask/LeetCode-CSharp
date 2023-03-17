namespace LeetCode;

public class PrimesCounter
{
    public int CountPrimes(int n)
    {
        if (n < 2)
        {
            return 0;
        }

        bool[] notPrime = new bool[n];
        int count = 0;

        for (int i = 2; i < n; i++)
        {
            if (!notPrime[i])
            {
                count++;
                for (int j = 2 * i; j < n; j += i)
                {
                    notPrime[j] = true;
                }
            }
        }

        return count;
    }
}