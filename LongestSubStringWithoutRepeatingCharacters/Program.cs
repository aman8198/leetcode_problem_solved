using System;
using System.Collections.Generic;
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        int maxLength = 0;
        int left = 0;
        HashSet<char> charSet = new HashSet<char>();

        for (int right = 0; right < s.Length; right++)
        {
            while (charSet.Contains(s[right]))
            {
                charSet.Remove(s[left]);
                left++;
            }
            charSet.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;

    }

    public static void Main()
    {
        Solution solution = new Solution();
        var result=solution.LengthOfLongestSubstring("abcabcbb");
        Console.WriteLine(result);
    }
}