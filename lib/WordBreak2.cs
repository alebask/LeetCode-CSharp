using System.Text;

namespace LeetCode;

public class WordBreakSolution2 {

    private Dictionary<string, bool> memo = new();

    public IList<string> WordBreak(string s, IList<string> wordDict) {

        IList<string> results = new List<string>();

        WordBreak(s, String.Empty, wordDict, results);

        return results;
    }


    public IList<string> WordBreak2(string s, IList<string> wordDict) {

        HashSet<string> dict = new(wordDict.Count);

        foreach (string word in wordDict) {
            dict.Add(word);
        }

        IList<string> results = new List<string>();

        WordBreak2(s, String.Empty, dict, results);

        return results;
    }

    public void WordBreak(string s, string r, IList<string> wordDict, IList<string> results) {

        if (String.Empty == s) {
            results.Add(r);
            return;
        }

        foreach (string word in wordDict) {

            if (s.StartsWith(word)) {

                string rr = (r == String.Empty) ? word : r + " " + word;
                string ss = s[word.Length..];
                WordBreak(ss, rr, wordDict, results);
            }
        }

    }

    public void WordBreak2(string s, string r, HashSet<string> wordDict, IList<string> results) {

        for (int i = 1, l = s.Length; i <= l; i++) {

            string word = s[..i];
            if (wordDict.Contains(word)) {
                string rr = (r == String.Empty) ? word : r + " " + word;
                string ss = s[i..];
                WordBreak2(ss, rr, wordDict, results);
            }
        }

        if (s == String.Empty) {
            results.Add(r);
        }

    }
}