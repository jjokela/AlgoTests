namespace Tests.Easy;

internal class MissingNumberTest
{
    public int MissingNumber(int[] nums)
    {
        var result = nums.Length;

        for (int i = 0; i < nums.Length; i++)
        {
            result += i - nums[i];
        }

        return result;
    }
}