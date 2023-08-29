namespace Tests.Easy;

public class BinarySearch
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            // get the middle value
            var middle = (left + right) / 2; // rounds down

            // target is greater than the middle value
            if (nums[middle] > target)
            {
                // move the right pointer
                right = middle - 1;
            } else if (nums[middle] < target) {
                // target is less than the middle value
                // move the left pointer
                left = middle + 1;
            }
            else
            {
                // middle == target
                return middle;
            }
        }

        // not found
        return -1;
    }
}