namespace LeetCode;
using System;

public class LongestNonRepeatingSubstring
{
    public static int Execute(string s)
    {
        int[] cache = new int[256]; //all zeroes
        int start = 0;
        int length = 0;
        int max = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (cache[ch] > 0)
            {
                start = Math.Max(start, cache[ch]);
                cache[ch] = i + 1;
                length = i + 1 - start;
            }
            else
            {
                length++;
                cache[ch] = i + 1;
            }


            max = Math.Max(max, length);

        }

        return max;

    }
}