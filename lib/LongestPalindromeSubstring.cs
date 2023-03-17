namespace LeetCode;

public class LongestPalindromeSubstring
{
    public string Execute(string s)
    {
        int sLen = s.Length;

        if (sLen == 1)
        {
            return s;
        }
        else if (sLen == 2)
        {
            return (s[0] == s[1]) ? s : s[..1];
        }

        int pStart = 0;
        int pLen = 1;

        for (int i = 0; i < sLen - 2; i++)
        {
            //even palindrome
            if (s[i] == s[i + 1])
                ProcessPalindrome(i, i + 1);

            //odd palindrome
            if (s[i] == s[i + 2])
                ProcessPalindrome(i, i + 2);
        }

        if (s[sLen - 2] == s[sLen - 1])
            ProcessPalindrome(sLen - 2, sLen - 1);

        void ProcessPalindrome(int left, int right)
        {
            while (left > 0 && right < sLen - 1)
            {
                if (s[left - 1] != s[right + 1])
                    break;
                left--; right++;
            }

            if (right - left + 1 > pLen)
            {
                pLen = right - left + 1;
                pStart = left;
            }
        }

        return s.Substring(pStart, pLen);
    }
}

