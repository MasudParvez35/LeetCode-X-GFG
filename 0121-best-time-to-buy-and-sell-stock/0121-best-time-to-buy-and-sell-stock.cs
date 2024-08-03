public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int mi = prices[0], ans = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            mi = Math.Min(mi, prices[i]);
            int x = prices[i] - mi;
            ans = Math.Max(ans, x);
        }
        return ans;
    }
}