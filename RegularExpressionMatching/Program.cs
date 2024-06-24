public class Solution
{
    public bool IsMatch(string s, string p)
    {
        int m = s.Length;
        int n = p.Length;
        bool[,] dp = new bool[m + 1, n + 1];

        dp[0, 0] = true;

        // Initialize dp for patterns with '*'
        for (int j = 1; j <= n; j++)
        {
            if (p[j - 1] == '*')
            {
                dp[0, j] = dp[0, j - 2];
            }
        }

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == '*')
                {
                    dp[i, j] = dp[i, j - 2] || (dp[i - 1, j] && (p[j - 2] == s[i - 1] || p[j - 2] == '.'));
                }
                else
                {
                    dp[i, j] = dp[i - 1, j - 1] && (p[j - 1] == s[i - 1] || p[j - 1] == '.');
                }
            }
        }

        return dp[m, n];
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.IsMatch("aa", "a"));        // Output: false
        Console.WriteLine(sol.IsMatch("aa", "a*"));       // Output: true
        Console.WriteLine(sol.IsMatch("ab", ".*"));       // Output: true
        Console.WriteLine(sol.IsMatch("aab", "c*a*b"));   // Output: true
        Console.WriteLine(sol.IsMatch("mississippi", "mis*is*p*.")); // Output: false
    }
}
