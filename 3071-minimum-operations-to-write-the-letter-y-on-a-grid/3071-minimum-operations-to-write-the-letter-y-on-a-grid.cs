public class Solution {
    public int Fun(int[][] a, int n, int x)
    {
        Dictionary<(int, int), int> mp = new Dictionary<(int, int), int>();
        int i = 0, j = n - 1, c = 0, c1 = 0;
        while (i < j)
        {
            if (a[i][i] != x) c++;
            if (a[i][j] != x) c++;
            mp[(i, i)] = 1;
            mp[(i, j)] = 1;
            i++; j--;
        }
        while (i < n)
        {
            if (a[i][n / 2] != x) c++;
            mp[(i, n / 2)] = 1;
            i++;
        }
        int mi = int.MaxValue;
        for (int k = 0; k <= 2; k++)
        {
            if (k != x)
            {
                c1 = 0;
                for (int l = 0; l < n; l++)
                {
                    for (int m = 0; m < n; m++)
                    {
                        if (!mp.ContainsKey((l, m)))
                        {
                            if (a[l][m] != k) c1++;
                        }
                    }
                }
                mi = Math.Min(mi, c + c1);
            }
        }
        return mi;
    }
    public int MinimumOperationsToWriteY(int[][] a) 
    {
        int n = a.Length, ans = int.MaxValue;
        for (int i = 0; i <= 2; i++)
        {
            int x = Fun(a,n,i);
            ans = Math.Min(ans, x);
        }
        return ans;
    }
}