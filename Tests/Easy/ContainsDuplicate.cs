namespace Tests.Easy
{
    public class ContainsDuplicateTest
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var setOfNumbers = new HashSet<int>(nums);

            return nums.Length == setOfNumbers.Count;
        }
    }
}
