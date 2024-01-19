public class Solution {
    public int MinFallingPathSum(int[][] a) 
    {
        int n = a.Length, mx = int.MaxValue;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int x = a[i][j] + a[i-1][j];
                if (j > 0) x = Math.Min(x, a[i][j] + a[i-1][j-1]);
                if (j+1 < n) x = Math.Min(x, a[i][j] + a[i-1][j+1]);
                a[i][j] = x;
            }
        }
        for (int i = 0; i < n; i++) mx = Math.Min(mx, a[n-1][i]);
        return mx;
    }
}