using System.Text;

namespace Tests.Easy;

internal class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        var sb = new StringBuilder();

        foreach (var ch in s.Where(char.IsLetterOrDigit))
        {
            sb.Append(char.ToLower(ch));
        }

        var cleanedString = sb.ToString();
        var reversedString = string.Join(string.Empty, cleanedString.Reverse().ToArray());

        return string.Equals(cleanedString, reversedString, StringComparison.Ordinal);
    }
}