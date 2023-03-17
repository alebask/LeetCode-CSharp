namespace LeetCode;

public class GenerateParenthesisTests
{


    [Theory]
    [MemberData(nameof(GetTestData))]

    public void ExecuteTest(int n, IList<string> expected)
    {
        GenerateParenthesis gp = new();

        IList<string> actual = gp.Execute(n);

        Assert.Equal(expected, actual);

    }

    public static IEnumerable<object[]> GetTestData()
    {

        yield return new object[]{
            1, new List<string>{"()"}
        };

        yield return new object[]{
            2, new List<string>{"(())", "()()"}.OrderByDescending(x=>x).ToList()
        };

        yield return new object[]{
            3, new List<string>{"((()))", "(()())", "(())()", "()(())", "()()()" }.OrderByDescending(x=>x).ToList()
    };

        yield return new object[]{
            4, new List<string>{ "(((())))","((()()))","((())())","((()))()","(()(()))","(()()())","(()())()","(())(())","(())()()","()((()))","()(()())","()(())()","()()(())","()()()()"}.OrderByDescending(x=>x).ToList()
        };
    }

}

// e ["(((())))","((()()))","((())())","((()))()","(()(()))","(()()())","(()())()","(())(())","(())()()","()((()))","()(()())","()(())()","()()(())","()()()()"]
// o ["()()()()","(()()())","()(()())","((()()))","(()())()","()()(())","(()(()))","()(())()","()((()))","(((())))","((()))()","((())())","(())()()"]

// e ["(())(())"]
// o []