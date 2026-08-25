public class Solution {
    public int MaxProfit(int[] prices) {

        int max_profit = 0;

        if (prices.Length <= 1) return max_profit;

        int i = 0;
        int j = 1;
        
        while (j < prices.Length)
        {
            if (prices[i] <= prices[j])
            {
                max_profit = Math.Max(max_profit, prices[j]-prices[i]);
                j++;
            } else {
                i = j;
                j++;
            }
        }

        return max_profit;
    }
}
