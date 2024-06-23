using System;
using System.Collections.Generic;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dict.ContainsKey(complement))
            {
                return new int[] { dict[complement], i };
            }
            dict[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");

    }

    public static void Main()
    {
        int[] arr = { 1, 3, 5, 2, 9 };
        int value = 8;
        Solution solution = new Solution();
        int[] result= solution.TwoSum(arr, value);
        foreach(var r in result)
        {
            Console.WriteLine(r);
        }
    }
}
