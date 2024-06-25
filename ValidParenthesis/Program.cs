public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false; //If the length of string is odd, it cant be valid
        }

        var stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                var top = stack.Pop();
                if ((c == ')' && top != '(') ||
                (c == '}' && top != '{') ||
                (c == ']' && top != '['))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    public static void Main()
    {
        Solution solution = new Solution();
        var result = solution.IsValid("()");
        Console.WriteLine(result);
    }
}