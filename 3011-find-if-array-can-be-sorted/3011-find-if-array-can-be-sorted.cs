public class Solution {
    public int Bit(int n) {
        int c = 0;
        while(n > 0) {
            if (n % 2 == 1) c++; 
            n /= 2;
        }
        return c;
    }
    public bool CanSortArray(int[] a) 
    {
        int mx = a[0], mi = a[0], pre = -1;
        for (int i = 1; i < a.Length; i++)
        {
            if (Bit(a[i-1]) == Bit(a[i]))
            {
                mx = Math.Max(mx, a[i]);
                mi = Math.Min(mi, a[i]);
            }
            else 
            {
                if (mi >= pre)
                {
                    pre = mx;
                    mx = a[i];
                    mi = a[i];
                }
                else return false;
            }
        }
        if (mi >= pre) return true;
        else return false;
    }
}
