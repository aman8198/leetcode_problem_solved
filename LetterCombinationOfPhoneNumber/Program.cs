using System.Text;

public class Solution
{
    private static readonly Dictionary<char, string> phoneMap = new Dictionary<char, string>(){
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"}
    };
    public IList<string> LetterCombinations(string digits)
    {

        var result = new List<string>();
        if (string.IsNullOrEmpty(digits))
        {
            return result;
        }

        BackTrack(result, new StringBuilder(), digits, 0);
        return result;
    }

    private void BackTrack(IList<string> result, StringBuilder combination, string digits, int index)
    {
        if (index == digits.Length)
        {
            result.Add(combination.ToString());
            return;
        }
        string letters = phoneMap[digits[index]];
        foreach (var letter in letters)
        {
            combination.Append(letter);
            BackTrack(result, combination, digits, index + 1);
            combination.Length--;
        }

    }

    public static void Main()
    {
        Solution solution = new Solution();
        var result = solution.LetterCombinations("23");
        Console.WriteLine(result);
    }
}