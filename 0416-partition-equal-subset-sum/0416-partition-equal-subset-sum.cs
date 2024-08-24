public class Solution {
    private bool Dfs(int[] a, int i, int sm, int[,] dp)
    {
        if (sm == 0) return true;
        if (sm < 0 || i < 0) return false;
        if (dp[i,sm] != -1) return dp[i,sm] == 1;
        bool take = Dfs(a, i-1, sm-a[i], dp);
        bool ntake = Dfs(a, i-1, sm, dp);
        dp[i,sm] = take || ntake ? 1 : 0;
        return dp[i,sm] == 1;
    }
    public bool CanPartition(int[] a) 
    {
        int n = a.Length, sm = 0;
        foreach (int item in a) 
            sm += item;
        if (sm % 2 != 0) return false;
        sm /= 2;
        int[,] dp = new int[n+1, sm+1];
        for (int i = 0; i <= n; i++) {
            for (int j = 0; j <= sm; j++) 
                dp[i,j] = -1;
        }
        return Dfs(a, n-1, sm, dp);
    }
}