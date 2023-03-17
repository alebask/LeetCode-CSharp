using System.Text;

namespace LeetCode;

public class CountAndSaySolution {

    public string CountAndSay(int n) {

        StringBuilder seed = new("1");
        StringBuilder newSeed = new();

        int i = 1;
        while (i < n) {

            int j = 0;
            while (j < seed.Length) {
                int count = 1;
                while (j < seed.Length - 1 && seed[j] == seed[j + 1]) {
                    count++;
                    j++;
                }
                newSeed.Append(count).Append(seed[j]);
                j++;
            }

            seed.Clear();
            seed.Append(newSeed);
            newSeed.Clear();
            i++;
        }

        return seed.ToString();
    }
}