namespace LeetCode;

public class MinWindowSubstring {
    public string MinWindow(string s, string t) {

        int m = s.Length, n = t.Length;

        if (m < n) {
            return String.Empty;
        }
        if (n == 1) {
            return s.Contains(t) ? t : String.Empty;
        }

        int[] limit = new int[128];

        foreach (char c in t) {
            limit[c]++;
        }

        int i = 0, j = 0, total = 0;
        int start = 0, len = 0;

        int[] count = new int[128];

        while (j < m) {

            char ch = s[j];
            if (limit[ch] > 0) {
                if (limit[ch] > count[ch]) {
                    total++;
                }
                count[ch]++;
            }
            j++;

            while (total == n) {

                int l = j - i;
                if (l < len || len == 0) {
                    start = i;
                    len = l;
                }

                ch = s[i];
                if (limit[ch] > 0) {
                    if (limit[ch] == count[ch]) {
                        total--;
                    }
                    count[ch]--;
                }
                i++;
            }
        }

        return s.Substring(start, len);
    }
}