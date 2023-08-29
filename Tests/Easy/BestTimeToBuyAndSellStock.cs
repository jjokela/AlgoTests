namespace Tests.Easy;

public class BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        var max = 0;
        var min = prices[0];

        foreach (var price in prices)
        {
            // check if we have a new floor value
            if (price < min)
            {
                min = price;
            }
            // check if we have a new ceiling value
            if (price - min > max)
            {
                max = price - min;
            }
        }

        return max;
    }
}