public class Solution
{
    public int RomanToInt(string s)
    {

        var romanMap = new Dictionary<char, int>(){
          {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
          {'C', 100}, {'D', 500}, {'M', 1000}
        };

        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            //Get the value of the current symbol
            int currentValue = romanMap[s[i]];

            // check if the next symbol is greater
            if (i + 1 < s.Length && romanMap[s[i + 1]] > currentValue)
            {
                //If next symbol is greater, subtract current value from result
                result -= currentValue;
            }
            else
            {
                //otherwise, add the current value to the result
                result += currentValue;
            }
        }
        return result;
    }

    public static void Main()
    {
        Solution solution = new Solution();
        var result = solution.RomanToInt("III");
        Console.WriteLine(result);
    }
}