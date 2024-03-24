public class Solution {
    public int MinOperations(int k) 
    {
        int ans = int.MaxValue;
        for (int i = 1; i <= k; i++)
        {
            if (i > k) break;
            int x = k - i;
            int y = (x+(i-1))/i;
            ans = Math.Min(ans, (i-1)+y);
        }
        return ans;
    }
}