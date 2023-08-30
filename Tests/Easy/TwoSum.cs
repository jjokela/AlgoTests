namespace Tests.Easy;

internal class TwoSumTest
{
    public int[] TwoSum(int[] nums, int target)
    {
        var numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var numToFind = target - nums[i];

            if (numMap.TryGetValue(numToFind, out var value))
            {
                return new[] { i, value };
            }

            numMap[nums[i]] = i;
        }

        return null;
    }
}