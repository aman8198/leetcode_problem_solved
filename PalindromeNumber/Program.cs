public class Solution
{
    public bool IsPalindrome(int x)
    {

        //Step1: Handle negativenumbers and multiples of 10(except 0)
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        int revertedNumber = 0;
        while (x > revertedNumber)
        {
            revertedNumber = revertedNumber * 10 + x % 10;
            x /= 10;
        }

        // Step3: Compare the first half and the second half
        return x == revertedNumber || x == revertedNumber / 10;

    }

    public static void Main()
    {
        Solution s = new Solution();
        var result = s.IsPalindrome(121);
        Console.WriteLine(result);
    }
}