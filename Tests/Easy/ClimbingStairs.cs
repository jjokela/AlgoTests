namespace Tests.Easy;

internal class ClimbingStairs
{
    public int ClimbStairs(int n)
    {
        var first = 1;
        var second = 1;

        for (int i = 0; i < n - 1; i++)
        {
            var temp = first;
            first = first + second;
            second = temp;
        }

        return first;
    }
}