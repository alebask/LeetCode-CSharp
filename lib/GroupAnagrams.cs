namespace LeetCode;

public class GroupAnagrams
{

    public IList<IList<string>> GroupWithDict2(string[] strs)
    {
        Dictionary<string, IList<string>> groups = new();

        foreach (string s in strs)
        {
            char[] tmp = new char[26];
            for (int i = 0; i < s.Length; i++)
            {
                tmp[s[i] - 'a']++;
            }
            string key = new(tmp);

            if (groups.ContainsKey(key))
            {

                groups[key].Add(s);
            }
            else
            {
                groups.Add(key, new List<string>() { s });
            }
        }

        IList<IList<string>> result = new List<IList<string>>(groups.Count);

        foreach (var item in groups.Values)
        {
            result.Add(item);
        }

        return result;
    }

    public IList<IList<string>> GroupLINQ(string[] strs)
    {
        return strs.GroupBy(s => String.Concat(s.OrderBy(ch => ch))).Select(x => x.ToArray()).ToArray();
    }

    public IList<IList<string>> GroupWithDict1(string[] strs)
    {
        Dictionary<string, IList<string>> groups = new();

        foreach (string s in strs)
        {
            char[] tmp = s.ToCharArray();
            Array.Sort(tmp);
            string key = new(tmp);

            if (groups.ContainsKey(key))
            {

                groups[key].Add(s);
            }
            else
            {
                groups.Add(key, new List<string>() { s });
            }
        }

        IList<IList<string>> result = new List<IList<string>>(groups.Count);

        foreach (var item in groups.Values)
        {
            result.Add(item);
        }

        return result;
    }
}