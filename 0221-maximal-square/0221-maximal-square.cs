public class Solution {
    int n, m, ans = 0;
    public bool search(char[][] a, int mid)
    {
        for (int i = 0; i <= n-mid; i++)
        {
            for (int j = 0; j <= m-mid; j++)
            {
                int x = i, c = 0;
                for (int I = 0; I < mid; I++)
                {
                    for (int k = j; k < j+mid; k++) {
                        if (a[x][k] == '1') c++;
                    }
                    x++;
                }
                if (c == mid*mid) return true;
            }
        }
        return false;
    }
    public int MaximalSquare(char[][] a) 
    {
        n = a.Length; 
        m = a[0].Length;
        int l = 1, r = Math.Min(n,m);
        while(l <= r)
        {
            int mid = (l+r)/2;
            bool x = search(a, mid);
            if (x) {
                ans = mid;
                l = mid+1;
            }
            else r = mid-1;
        }
        return ans*ans;
    }
}