using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        var result = new List<IList<int>>();
        if (nums == null || nums.Length < 4) return result;

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue; // Skip duplicates for the first element

            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue; // Skip duplicates for the second element

                int left = j + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++; // Skip duplicates for the third element
                        while (left < right && nums[right] == nums[right - 1]) right--; // Skip duplicates for the fourth element

                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }

    public static void Main()
    {
        Solution solution = new Solution();
        var result = solution.FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0);
        Console.WriteLine(result);
    }
}
