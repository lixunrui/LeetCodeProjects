public class Worker
{
    public static int MaxProfit(int[] prices)
    {
        int buyDay = 0;
        int sellDay = 0;
        int profit = 0;

        int period = prices.Length - 1;
        int dayIndex = 0;
        while (dayIndex < period)
        {
            // the checking order matters
            // otherwie it gives an out of boundary error
            while (dayIndex < period && prices[dayIndex + 1] < prices[dayIndex])
            {
                dayIndex++;
            }
            buyDay = dayIndex;

            while (dayIndex < period && prices[dayIndex + 1] > prices[dayIndex])
            {
                dayIndex++;
            }
            sellDay = dayIndex;

            profit += prices[sellDay] - prices[buyDay];
            if (sellDay == buyDay)
            {
                dayIndex++;
            }
        }

        return profit;
    }
}

