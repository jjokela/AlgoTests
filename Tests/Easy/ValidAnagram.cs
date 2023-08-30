namespace Tests.Easy;

internal class ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var counter = new int[26]; // Assuming lowercase English letters

        foreach (var ch in s)
        {
            counter[ch - 'a']++;
        }

        foreach (var ch in t)
        {
            counter[ch - 'a']--;
        }

        foreach (var count in counter)
        {
            if (count != 0)
            {
                return false;
            }
        }

        return true;
    }
}