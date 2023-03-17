namespace LeetCode;

public class GenerateParenthesis
{

    //*(*)*
    public IList<String> Execute(int n)
    {
        List<string> result = new();

        GenerateParenthesisRecursive(n, new char[2 * n], 0, 0, 0, result);

        return result;
    }

    private void GenerateParenthesisRecursive(int n, char[] s, int index, int openCount, int closeCount, List<string> result)
    {

        if (index == 2 * n)
        {
            result.Add(new string(s));
        }
        else
        {
            if (closeCount < openCount)
            {
                s[index] = ')';
                GenerateParenthesisRecursive(n, s, index + 1, openCount, closeCount + 1, result);
            }
            if (openCount < n)
            {
                s[index] = '(';
                GenerateParenthesisRecursive(n, s, index + 1, openCount + 1, closeCount, result);
            }
        }
    }
}