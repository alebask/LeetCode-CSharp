namespace LeetCode;

public class DecoeWays
{
    public int NumDecodingsDP(string s)
    {
        if (s[0] == '0')
        {
            return 0;
        }

        int r_prev = 1;
        int r_curr = 1;

        int r_next = 0;

        for (int i = 1; i < s.Length; i++)
        {
            int n_curr = s[i] - '0';
            int n_prev = s[i - 1] - '0';

            if (n_prev == 0 && n_curr == 0 || n_curr == 0 && (n_prev * 10 + n_curr) > 26)
            {
                return 0;
            }
            else if (n_prev == 0 || (n_prev * 10 + n_curr) > 26)
            {
                r_next = r_curr;
            }
            else if (n_curr == 0)
            {
                r_next = r_prev;
            }
            else
            {
                r_next = r_curr + r_prev;
            }

            r_prev = r_curr;
            r_curr = r_next;
        }

        return r_next;
    }


    public int NumDecodings(string s)
    {
        Dictionary<int, int> dict = new();
        return NumDecodingsRecursive(s, 0, dict);
    }

    public int NumDecodingsRecursive(string s, int i, Dictionary<int, int> dict)
    {
        if (i == s.Length)
        {
            return 1;
        }

        if (s[i] == '0')
        {
            return 0;
        }

        if (dict.ContainsKey(i))
        {
            return dict[i];
        }

        int result = 0;

        result += NumDecodingsRecursive(s, i + 1, dict);

        if (i < s.Length - 1 && (s[i] - '0') * 10 + (s[i + 1] - '0') <= 26)
        {
            result += NumDecodingsRecursive(s, i + 2, dict);
        }

        dict.Add(i, result);

        return result;
    }
}