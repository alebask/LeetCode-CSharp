namespace LeetCode;

public class ValidParenthesis
{

    public bool IsValid(string s)
    {
        Stack<char> box = new Stack<char>();

        foreach (char ch in s)
        {
            switch (ch)
            {
                case '(': box.Push(')'); break;
                case '{': box.Push('}'); break;
                case '[': box.Push(']'); break;

                default:
                    if (box.Count == 0 || box.Pop() != ch)
                    {
                        return false;
                    }
                    break;

            }
        }

        return (box.Count == 0);
    }
}