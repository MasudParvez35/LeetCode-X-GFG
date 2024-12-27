public class Solution {
    public int MaxScoreSightseeingPair(int[] values) 
    {
        int ans = 0, maxLeft = values[0];
        for (int ind = 1; ind < values.Length; ind++)
        {
            ans = Math.Max(ans, maxLeft + values[ind] - ind);
            maxLeft = Math.Max(maxLeft, values[ind]+ind);
        }
        return ans;
    }
}