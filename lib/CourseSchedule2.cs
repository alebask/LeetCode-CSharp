namespace LeetCode;

public class CourseSchedule2 {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        Dictionary<int, Node> nodes = new(numCourses);

        for (int i = 0; i < numCourses; i++) {
            nodes.Add(i, new Node(i));
        }

        for (int i = 0, l = prerequisites.Length; i < l; i++) {
            int n = prerequisites[i][0];
            int p = prerequisites[i][1];
            nodes[n].PrevCount++;
            nodes[p].NextNodes.Add(n);
        }

        int[] result = new int[numCourses];
        int r = 0;
        Node? noPrevCountNode;
        do {
            noPrevCountNode = null;
            foreach (var kv in nodes) {
                if (kv.Value.PrevCount == 0) {
                    noPrevCountNode = kv.Value;
                    foreach (int num in noPrevCountNode.NextNodes) {
                        nodes[num].PrevCount--;
                    }
                    result[r] = noPrevCountNode.Value;
                    r++;
                    nodes.Remove(noPrevCountNode.Value);
                }
            }
        }
        while (noPrevCountNode != null);

        return (r < numCourses) ? Array.Empty<int>() : result;
    }

    public class Node {
        public int Value;
        public int PrevCount = 0;
        public List<int> NextNodes = new();

        public Node(int value = 0) {
            this.Value = value;
        }
    }
}