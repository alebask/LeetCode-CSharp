namespace LeetCode;

public class Checker : IComparer<Player> {
    public int Compare(Player? x, Player? y) {
        if (x == null && y != null) {
            return -1;
        }
        if (x != null && y == null) {
            return 1;
        }
        if (x == null && y == null) {
            return 0;
        }

        int result = -x!.score.CompareTo(y!.score);

        if (result == 0) {
            if (x.name == null && y.name != null) {
                return -1;
            }
            if (x.name == null && y.name == null) {
                return 0;
            } else {
                return x.name!.CompareTo(y.name);
            }
        }
        return result;
    }
}

public class Player {
    public string name;
    public string score;
}