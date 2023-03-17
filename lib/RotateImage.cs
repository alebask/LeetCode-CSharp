namespace LeetCode;

public class RotateImage
{
    public void Rotate(int[][] matrix)
    {
        int len = matrix.Length;

        for (int i = 0; i < len; i++)
        {
            for (int j = i; j < len; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }

        for (int i = 0; i < len; i++)
        {
            for (int j = 0, l = len / 2; j < l; j++)
            {
                (matrix[i][j], matrix[i][len - 1 - j]) = (matrix[i][len - 1 - j], matrix[i][j]);
            }
        }
    }
}