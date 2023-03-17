namespace LeetCode;

public class MyAtoi
{
    public int Execute(string s)
    {
        int len = s.Length;
        int ptr = 0;

        //skip leading white space
        while (ptr < len)
        {
            if (s[ptr] == ' ')
            {
                ptr++;
            }
            else { break; }
        }

        // check negative sign        
        bool positive = true;
        if (ptr < len)
        {
            if (s[ptr] == '+')
            {
                ptr++;
            }
            else if (s[ptr] == '-')
            {
                positive = false;
                ptr++;
            }
        }

        int result = 0;
        while (ptr < len)
        {
            if (s[ptr] >= '0' && s[ptr] <= '9')
            {

                //handle overflow
                if (result > Int32.MaxValue / 10 ||
                (result == Int32.MaxValue / 10 && s[ptr] - '0' > Int32.MaxValue % 10))
                {
                    result = (positive) ? Int32.MaxValue : Int32.MinValue;
                    break;
                }

                result = result * 10 + (s[ptr] - '0');
                ptr++;
            }
            else
            {
                break;
            }
        }
        return (positive) ? result : -result;
    }
}