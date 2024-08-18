public class Solution {
    private int Dfs(int[] a, int i, int t, List<List<int>> dp)
    {
        if (i < 0 || t < 0) return int.MaxValue / 2;
        if (i == 0)
        {
            return t % a[i] == 0 ? t / a[i] : int.MaxValue / 2;
        }
        if (dp[i][t] != -1) return dp[i][t];
        
        int take = 1 + Dfs(a, i, t - a[i], dp);
        int ntake = Dfs(a, i - 1, t, dp);
        
        return dp[i][t] = Math.Min(take, ntake);
    }
    public int CoinChange(int[] a, int t) 
    {
        int n = a.Length;
        var dp = new List<List<int>>(n+1);
        for (int i = 0; i <= n; i++) {
            dp.Add(new List<int>(new int[t+1]));
            for (int j = 0; j <= t; j++) dp[i][j] = -1;
        }
        int ans = Dfs(a, n - 1, t, dp);
        return ans >= int.MaxValue / 2 ? -1 : ans;
    }
}