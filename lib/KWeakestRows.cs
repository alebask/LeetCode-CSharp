namespace LeetCode
{
    public class KWeakestRows
    {

        public static int[] Execute(int[][] mat, int k)
        {
            PriorityQueue<int, (int, int)> queue = new(k, Comparer<(int, int)>.Create(
             (a, b) => (a.Item1 != b.Item1) ? a.Item1 - b.Item1 : a.Item2 - b.Item2
             ));

            for (int i = 0; i < mat.Length; i++)
            {
                int[] row = mat[i];
                int p = GetRowStrength(row);
                queue.Enqueue(i, (p, i));
            }

            int[] result = new int[k];

            for (int i = 0; i < k; i++)
            {
                result[i] = queue.Dequeue();
            }

            return result;
        }

        private static int GetRowStrength(int[] row)
        {
            int left = 0;
            int right = row.Length;

            while (left < right)
            {
                int half = (right + left) / 2;

                if (row[half] == 1)
                {
                    left = half + 1;
                }
                else
                {
                    right = half;
                }
            }

            return left;
        }
    }

}
