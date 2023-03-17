namespace LeetCode;

public class WildcardMatching
{

    public bool IsMatch(string s, string p)
    {
        int i = 0;
        int j = 0;
        int star = -1;
        int lastMatch = 0;

        while (i < s.Length)
        {
            if (j < p.Length && (s[i] == p[j] || p[j] == '?'))
            {
                i++;
                j++;
            }
            else if (j < p.Length && p[j] == '*')
            {
                lastMatch = i;
                star = j++;
            }
            else if (star >= 0)
            {
                j = star + 1;
                i = ++lastMatch;
            }
            else
            {
                return false;
            }
        }

        while (j < p.Length && p[j] == '*') { j++; }

        return j == p.Length;
    }

    public bool IsMatchRecursive(string s, string p, Dictionary<(string, string), bool> dict)
    {
        if (p == String.Empty)
        {
            return s == String.Empty;
        }
        if (p == "*")
        {
            return true;
        }
        if (s == String.Empty)
        {
            for (int i = 0; i < p.Length; i++)
                if (p[i]! != '*') return false;
            return true;
        }

        if (dict.ContainsKey((s, p)))
        {
            return dict[(s, p)];
        }


        bool result = false;

        if (p[0] == '*')
        {
            //shrink multi '*'
            //shrink multi '*'
            int n = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '*') { n++; }
                else { break; }
            }

            result = IsMatchRecursive(s, p[n..], dict);
            dict.TryAdd((s, p[n..]), result);
            if (result)
            {
                return true;
            }
            if (s.Length > 0)
            {
                result = IsMatchRecursive(s[1..], p[(n - 1)..], dict);
                dict.TryAdd((s[1..], p[(n - 1)..]), result);
                return result;
            }
        }
        else
        {
            if (s.Length > 0 && s[0] == p[0] || p[0] == '?')
            {
                result = IsMatchRecursive(s[1..], p[1..], dict);
                dict.TryAdd((s[1..], p[1..]), result);
                return result;
            }
        }

        return false;
    }
}