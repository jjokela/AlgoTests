namespace Tests.Easy;

internal class SingleNumberTest
{
    public int SingleNumber(int[] nums)
    {
        var xor = 0;

        foreach (var num in nums)
        {
            xor ^= num;
        }

        return xor;
    }
}