public class Solution {
    public int dfs(int[] a, int i, int k, int[] dp)
    {
        if (i >= a.Length) return 0;
        if (dp[i] != -1) return dp[i];
        int len = 0, mx = 0, ans = 0;
        for (int j = i; j < Math.Min(i+k, (int)a.Length); j++)
        {
            mx = Math.Max(mx, a[j]);
            len++;
            int sm = mx*len + dfs(a,j+1,k,dp);
            ans = Math.Max(ans, sm);
        }
        return dp[i] = ans;
    }
    public int MaxSumAfterPartitioning(int[] a, int k) 
    {
        int n = a.Length;
        int[] dp = new int[n];
        Array.Fill(dp, -1);
        return dfs(a,0,k,dp);
    }
}