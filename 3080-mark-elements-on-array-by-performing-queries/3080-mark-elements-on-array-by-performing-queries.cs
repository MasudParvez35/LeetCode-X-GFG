public class Solution {
    public long[] UnmarkedSumArray(int[] a, int[][] q) 
    {
        List<(int, int)> vp = new List<(int,int)>();
        int n = a.Length, m = q.Length;
        long sm = 0;
        long[] ans = new long[m];
        for (int i = 0; i < n; i++) {
            sm += a[i];
            vp.Add((a[i], i));
        }
        vp.Sort();
        Dictionary<int,int> mp = new Dictionary<int,int>();
        
        int ind = 0, ase = n;
        for (int i = 0; i < m; i++)
        {
            int x = q[i][0], y = q[i][1];
            if (!mp.ContainsKey(x))
            {
                sm -= a[x];
                ase--;
                mp[x] = 1;
            }
            int c = Math.Min(ase, y);
            while (c > 0)
            {
                if (mp.ContainsKey(vp[ind].Item2))
                {
                    ind++;
                }
                else
                {
                    sm -= vp[ind].Item1;
                    ase--;
                    mp[vp[ind].Item2] = 1;
                    c--;
                    ind++;
                }
            }
            ans[i] = sm;
        }
        return ans;
    }
}