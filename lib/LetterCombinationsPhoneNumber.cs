using System.Linq;

namespace LeetCode;

public class LetterCombinationsPhoneNumber
{

    private static Dictionary<char, char[]> _map = new(){
            {'2', new char []{'a', 'b', 'c'}},
            {'3', new char []{'d', 'e', 'f'}},
            {'4', new char []{'g', 'h', 'i'}},
            {'5', new char []{'j', 'k', 'l'}},
            {'6', new char []{'m', 'n', 'o'}},
            {'7', new char []{'p', 'q', 'r', 's'}},
            {'8', new char []{'t', 'u', 'v'}},
            {'9', new char []{'w', 'x', 'y', 'z'}}
        };

    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits)) return Array.Empty<string>();

        List<string> result = new();

        char[] combination = new char[digits.Length];
        int[] indexes = new int[digits.Length];

        bool complete = false;
        while (!complete)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                combination[i] = _map[digits[i]][indexes[i]];
            }

            result.Add(new string(combination));

            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] < _map[digits[i]].Length - 1)
                {
                    indexes[i]++;
                    break;
                }
                else
                {
                    if (i == indexes.Length - 1)
                    {
                        complete = true;
                        break;
                    }

                    indexes[i] = 0;
                }
            }
        }

        return result;
    }


    public IList<string> LetterCombinationsLINQ(string digits)
    {
        if (string.IsNullOrEmpty(digits)) return Array.Empty<string>();



        var letters = digits.Select(ch => _map[ch]);

        var cartesianProduct = letters.Aggregate(
           (IEnumerable<IEnumerable<char>>)new[] { Enumerable.Empty<char>() },
           (acc, src) => src.SelectMany(x => acc.Select(a => a.Append(x)))
        );

        var result = cartesianProduct.Select(chars => new string(chars.ToArray())).ToArray();

        return result;
    }
}

