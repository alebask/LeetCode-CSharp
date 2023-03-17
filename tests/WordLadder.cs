namespace LeetCode;

public class WordLadder {

    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {

        HashSet<string> beginSet = new();
        HashSet<string> endSet = new();
        HashSet<string> processed = new();

        HashSet<string> list = new(wordList);

        if (!wordList.Contains(endWord)) {
            return 0;
        }

        beginSet.Add(beginWord);
        endSet.Add(endWord);

        int result = 1;

        while (beginSet.Count > 0 && endSet.Count > 0) {

            if (beginSet.Count > endSet.Count) {

                (beginSet, endSet) = (endSet, beginSet);

            }

            HashSet<string> newSet = new();
            foreach (string word in beginSet) {

                char[] letters = word.ToCharArray();

                for (int i = 0; i < letters.Length; i++) {

                    char old = letters[i];

                    for (char c = 'a'; c <= 'z'; c++) {

                        letters[i] = c;
                        string str = new(letters);

                        if (endSet.Contains(str)) {
                            return result + 1;
                        }

                        if (!processed.Contains(str) && list.Contains(str)) {
                            newSet.Add(str);
                            processed.Add(str);
                        }
                    }

                    letters[i] = old;
                }
            }
            beginSet = newSet;
            result++;
        }

        return 0;
    }
}