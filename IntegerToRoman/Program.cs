using System.Text;

public class Solution
{
    public string IntToRoman(int num)
    {

        //Dictionary to map roman symbols to their corresponding integer values
        Dictionary<int, string> romanMap = new Dictionary<int, string>(){
         {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
         {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
         {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
        };

        var roman = new StringBuilder();

        //Iterate through the dictionary
        foreach (var item in romanMap)
        {
            //Append the roman symbol as many times as possible
            while (num >= item.Key)
            {
                roman.Append(item.Value);
                num -= item.Key;
            }
        }
        return roman.ToString();

    }

    public static void Main()
    {
        Solution solution = new Solution();
        var result = solution.IntToRoman(1994);
        Console.WriteLine(result);
    }
}