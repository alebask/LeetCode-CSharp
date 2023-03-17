namespace LeetCode;

public class FractionRecurringDecimal {
    public string FractionToDecimal(int numerator, int denominator) {

        long n = (long)numerator;
        long d = (long)denominator;

        long i = n / d;
        long r = n % d;

        if (r == 0) {
            return i.ToString();
        }

        string sign = (numerator < 0 ^ denominator < 0) ? "-" : "";
        string result = sign + Math.Abs(i).ToString() + ".";
        Dictionary<long, int> rems = new();

        while (r != 0) {

            r *= 10;
            i = r / d;
            r %= d;

            result += Math.Abs(i).ToString();

            if (rems.ContainsKey(r)) {
                return result[..rems[r]] + "(" + result[rems[r]..] + ")";
            } else {
                rems.Add(r, result.Length);
            }
        }

        return result;
    }
}