namespace LeetCode;

public class LongestCommonPrefix
{

    public string Execute(string[] strs)
    {
        if (strs.Length == 0) return string.Empty;
        if (strs.Length == 1) return strs[0];

        int len = 0;
        bool common = true;

        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (i < strs[j].Length)
                {
                    if (strs[0][i] != strs[j][i])
                    {
                        common = false;
                        break;
                    }
                }
                else
                {
                    common = false;
                    break;
                }
            }
            if (common)
            {
                len = i + 1;
            }
            else { break; }
        }

        return strs[0][..len];

    }
}