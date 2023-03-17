namespace LeetCode;

public class RegularExpressionMatching
{
    public bool IsMatch(string s, string p)
    {
        if (p.Length == 0)
        {
            return s.Length == 0;
        }

        if (p.Length > 1 && p[1] == '*')
        {
            if (IsMatch(s, p[2..]))
            {
                return true;
            }

            if (s.Length > 0 && (s[0] == p[0] || p[0] == '.'))
            {
                return IsMatch(s[1..], p);
            }
        }
        else
        {
            if (s.Length > 0 && (s[0] == p[0] || p[0] == '.'))
            {
                return IsMatch(s[1..], p[1..]);
            }
        }

        return false;
    }
}