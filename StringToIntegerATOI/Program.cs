public class Solution
{
    public int MyAtoi(string s)
    {

        if (string.IsNullOrEmpty(s)) return 0;

        int i = 0, n = s.Length, sign = 1, result = 0;

        //Step 1: Skip leading whitespace
        while (i < n && s[i] == ' ')
        {
            i++;
        }

        //Step 2: Check for sign
        if (i < n && (s[i] == '+' || s[i] == '-'))
        {
            sign = (s[i] == '-') ? -1 : 1;
            i++;
        }

        //Step 3: Convert digits to integer and handle overflow
        while (i < n && char.IsDigit(s[i]))
        {
            int digit = s[i] - '0';

            //Check for overflow
            if (result > (int.MaxValue - digit) / 10)
            {
                return (sign == 1) ? int.MaxValue : int.MinValue;
            }
            result = result * 10 + digit;
            i++;
        }

        return result * sign;
    }

    public static void Main()
    {
        Solution s = new Solution();
        var result = s.MyAtoi("42");
        Console.WriteLine(result);  
    }
}