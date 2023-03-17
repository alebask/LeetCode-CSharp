namespace LeetCode;


public class SpiralMatrix
{

    public IList<int> SpiralOrder(int[][] matrix)
    {
        int reslen = matrix.Length * matrix[0].Length;
        int[] result = new int[reslen];

        int i = 0, j = 0, k = 0;

        int imin = 0, imax = matrix.Length - 1;
        int jmin = 0, jmax = matrix[0].Length - 1;

        while (k < reslen)
        {
            result[k] = matrix[i][j];
            k++;

            if (i == imin && j < jmax)
            {
                j++;
            }
            else if (j == jmax && i < imax)
            {
                i++;
            }
            else if (j > jmin && i == imax)
            {
                j--;
                if (j == jmin)
                {
                    imin++;
                    imax--;
                }
            }
            else if (i > imin && j == jmin)
            {
                i--;
                if (i == imin)
                {
                    jmax--;
                    jmin++;
                }
            }
        }

        return result;
    }

}