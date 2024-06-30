public class Solution {
    public int Count(int[] a, int x)
    {
        int cnt = 0;
        foreach(int i in a) {
            if (i == x) {
                cnt++;
                x++;
                x %= 2;
            }
        }
        return cnt;
    }
    public int MaximumLength(int[] a) 
    {
        int zero = 0, one = 0;
        for (int i = 0; i < a.Length; i++) {
            a[i] = a[i] % 2;
            if (a[i] == 0) zero++;
            else one++;
        }
        int ans = Math.Max(one, zero), c = 1;
        for (int i = 0; i < a.Length-1; i++)
        {
            if (a[i] == a[i+1]) {
                c++;
                ans = Math.Max(ans, c);
            }
            else c = 1;
        }
        ans = Math.Max(ans, Count(a, 1));
        ans = Math.Max(ans, Count(a, 0));
        return ans;
    }
}