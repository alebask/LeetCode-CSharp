namespace LeetCode;

public class PlusOne
{
    public int[] Execute(int[] digits)
    {
        int[] arr = digits;

        int i = arr.Length - 1;

        while (i >= 0)
        {
            if (arr[i] == 9)
            {
                arr[i] = 0;
            }
            else
            {
                arr[i]++;
                break;
            }

            i--;
        }

        if (arr[0] == 0)
        {
            int[] tmp = new int[arr.Length + 1];
            tmp[0] = 1;

            arr = tmp;
        }

        return arr;
    }
}

