public class Solution {
    int dfs(int[] a, int i, int[] dp)
    {
        if (i < 0) return 0;
        if (dp[i] != -1) return dp[i];
        int take = a[i] + dfs(a, i-2, dp);
        int ntake = dfs(a, i-1, dp);
        return dp[i] = Math.Max(take, ntake);
    }
    public int Rob(int[] a) 
    {
        int n = a.Length;
        int[] dp = new int[n+1];
        Array.Fill(dp, -1);
        return dfs(a, n-1, dp);
    }
}