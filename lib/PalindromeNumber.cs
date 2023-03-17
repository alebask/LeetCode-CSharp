namespace LeetCode;


public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x > 0 && x % 10 == 0) return false;

        int num = x;
        int rev = 0;

        while (num > rev)
        {
            rev = num % 10 + rev * 10;
            num = num / 10;
        }

        return (num == rev || num == rev / 10);
    }
}

// if (x< 0) return false;

//         List<int> l = new List<int>();

// int n = x;
//         while (n > 0)
//         {
//             l.Add(n % 10);
//             n /= 10;
//         }

//         for (int i = 0; i < l.Count / 2; i++)
// {
//     if (l[i] != l[l.Count - i - 1])
//     {
//         return false;
//     }

// }

// return true;