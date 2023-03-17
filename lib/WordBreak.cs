namespace LeetCode;

public class WordBreakSolution {

    private Dictionary<string, bool> memo = new();
    public bool WordBreak(string s, IList<string> wordDict) {

        if (String.Empty == s) {
            return true;
        }

        foreach (string word in wordDict) {

            if (s.StartsWith(word)) {

                string ss = s[word.Length..];

                if (!memo.TryGetValue(ss, out bool result)) {
                    result = WordBreak(ss, wordDict);
                    memo.Add(ss, result);
                }

                if (true == result) {
                    return true;
                }
            }
        }

        return false;
    }
}