namespace Tests.Easy;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        var closeToOpen = new Dictionary<char, char>
        {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        var openingCharStack = new Stack<char>();

        foreach (var c in s)
        {
            if (closeToOpen.TryGetValue(c, out var closeToOpenChar))
            {
                if (openingCharStack.TryPeek(out var openingChar) && openingChar == closeToOpenChar)
                {
                    openingCharStack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                openingCharStack.Push(c);
            }
        }

        return openingCharStack.Count <= 0;
    }
}