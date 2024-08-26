public class Solution {
    private int lcs(string s, string t, int i, int j, int[][] dp)
    {
        if (i < 0 || j < 0) return 0;
        if (dp[i][j] != -1) return dp[i][j];
        int take = 0;
        if (s[i] == t[j]) {
            take = 1 + lcs(s, t, i-1, j-1, dp);
        }
        int ntake = Math.Max(lcs(s,t,i-1,j,dp),lcs(s,t,i,j-1,dp));
        return dp[i][j] = Math.Max(take, ntake);
    }
    public int LongestCommonSubsequence(string s, string t) 
    {
        int n = s.Length, m = t.Length;
        int[][] dp = new int[n][];
        for (int i = 0; i < n; i++) {
            dp[i] = new int[m];
            Array.Fill(dp[i], -1);
        }

        return lcs(s, t, n-1, m-1, dp);
    }
}