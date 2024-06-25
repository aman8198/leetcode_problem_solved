public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {

        var result = new List<IList<int>>();

        if (nums == null || nums.Length < 3)
        {
            return result;
        }

        //sort the array
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            //skip the same element to avoid duplicates
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    //skip duplicates for the left pointer
                    while (left < right && nums[left] == nums[left + 1])
                    {
                        left++;
                    }

                    //skip duplicates for the right pointer
                    while (left < right && nums[right] == nums[right - 1])
                    {
                        right--;
                    }

                    //Move both pointers after finding a valid triplet 
                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
        return result;

    }

    public static void Main()
    {
        Solution solution = new Solution();
        var nums = new int[] { -1, 0, 1, 2, -1, -4 };
        var result = solution.ThreeSum(nums);
        Console.WriteLine(result);
    }
}