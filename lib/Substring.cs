namespace LeetCode;

public class Substring
{
    //"mississippi"
    // "issi"
    //"leetcode"
    //"leeto" 
    public int Execute(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(haystack)) return -1;
        if (string.IsNullOrEmpty(needle)) return -1;
        if (haystack == needle) return 0;
        if (haystack.Length < needle.Length) return -1;

        int result = -1;
        int j = 0;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] != needle[j])
            {
                i -= j;
                j = 0;
            }
            else
            {
                j++;
            }

            if (j == needle.Length)
            {
                result = i - j + 1;
                break;
            }
        }

        return result;

    }

}