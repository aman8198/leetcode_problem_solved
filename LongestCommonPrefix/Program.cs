public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        //start with the first string in the array as the initial prefix
        string prefix = strs[0];

        //compare the prefix with each string in the array
        for (int i = 1; i < strs.Length; i++)
        {
            //shorten the prefix until it matches the start of the current string
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix.Length == 0)
                {
                    return "";
                }
            }
        }
        return prefix;
    }

    public static void Main()
    {
        Solution solution = new Solution();
        var testData = new string[]
        {
            "flower","flow","flight"
        };
        var result = solution.LongestCommonPrefix(testData);
        Console.WriteLine(result);
    }
}