public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;

        string[] rows = new string[Math.Min(numRows, s.Length)];
        for (int i = 0; i < rows.Length; i++)
        {
            rows[i] = string.Empty;
        }

        int curRow = 0;
        bool goingDown = false;

        foreach (char c in s)
        {
            rows[curRow] += c;
            if (curRow == 0 || curRow == numRows - 1) goingDown = !goingDown;
            curRow += goingDown ? 1 : -1;
        }

        string result = string.Empty;
        foreach (string row in rows)
        {
            result += row;
        }

        return result;


    }

    public static void main()
    {
        Solution s = new Solution();
        var result = s.Convert("PAYPALISHIRING", 3);
        Console.WriteLine(result);
    }
}