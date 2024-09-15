public class Solution {
    long Dfs(int[] a, int[] b, int i, int j, long[][] dp)
    {
        if (i == 4) return 0;
        if (j == b.Length) return int.MinValue;
        if (dp[i][j] != -1) return dp[i][j];
        long take = (long)a[i] * (long)b[j] + Dfs(a, b, i+1, j+1, dp);
        long ntake = Dfs(a, b, i, j+1, dp);
        return dp[i][j] = Math.Max(take, ntake);
    }
    public long MaxScore(int[] a, int[] b) 
    {
        long[][] dp = new long[4][];
        for (int i = 0; i < 4; i++) {
            dp[i] = new long[b.Length+1];
            for (int j = 0; j < b.Length; j++) {
                dp[i][j] = -1;
            }
        }
        return Dfs(a, b, 0, 0, dp);
    }
}