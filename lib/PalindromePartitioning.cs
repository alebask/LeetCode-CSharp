namespace LeetCode;

public class PalindromePartitioning {

    public IList<IList<string>> Partition(string s) {

        List<IList<string>> result = new() { new List<string>(s.Length) };
        IList<string> item;
        List<string> newItem;
        string si;
        int last, prev;

        for (int i = 0, sl = s.Length; i < sl; i++) {

            si = s[i].ToString();

            for (int j = 0, rl = result.Count; j < rl; j++) {

                item = result[j];
                last = item.Count - 1;
                prev = last - 1;

                if (last >= 0 && item[last] == si) {
                    newItem = new(item);
                    newItem[last] = item[last] + si;
                    result.Add(newItem);
                }

                if (last >= 1 && item[prev] == si) {
                    newItem = new(item);
                    newItem[prev] = item[prev] + item[last] + si;
                    newItem.RemoveAt(last);
                    result.Add(newItem);
                }

                item.Add(si);
            }
        }
        return result;
    }
}