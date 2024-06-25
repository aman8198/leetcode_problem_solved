public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {

        //Sort the array 
        Array.Sort(nums);

        int closestSum = nums[0] + nums[1] + nums[2];

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int currentSum = nums[i] + nums[left] + nums[right];

                //if the current sum is closer to the target, update the closest sum
                if (Math.Abs(currentSum - target) < Math.Abs(closestSum - target))
                {
                    closestSum = currentSum;
                }

                if (currentSum < target)
                {
                    left++;
                }
                else if (currentSum > target)
                {
                    right--;
                }
                else
                {
                    //If the current sum is exactly the target, return the target sum
                    return currentSum;
                }
            }
        }
        return closestSum;
    }

    public static void Main()
    {
        Solution solution = new Solution();
        var testData = new int[] { -1, 2, 1, -4 };
        var result = solution.ThreeSumClosest(testData, 1);
        Console.WriteLine(result);
    }
}