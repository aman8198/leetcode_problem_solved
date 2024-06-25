public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int width = right - left;
            int currentHeight = Math.Min(height[left], height[right]);
            int currentArea = width * currentHeight;
            maxArea = Math.Max(maxArea, currentArea);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }

    public static void Main()
    {
        Solution solution = new Solution();
        var testData = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        var result = solution.MaxArea(testData);
        Console.WriteLine(result);
    }
}
