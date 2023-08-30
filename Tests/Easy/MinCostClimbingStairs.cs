namespace Tests.Easy;

internal class MinCostClimbingStairsTest
{
    public int MinCostClimbingStairs(int[] cost)
    {
        var costList = new List<int>(cost);
        costList.Append(0);

        for (int i = costList.Count - 3; i >= 0; i--)
        {
            var oneStep = costList[i + 1];
            var twoSteps = costList[i + 2];

            var minCost = Math.Min(oneStep, twoSteps);

            costList[i] += minCost;
        }

        return Math.Min(costList[0], costList[1]);
    }
}