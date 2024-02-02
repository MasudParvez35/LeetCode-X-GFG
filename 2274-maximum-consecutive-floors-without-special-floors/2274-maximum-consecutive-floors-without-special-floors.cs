public class Solution {
    public int MaxConsecutive(int l, int r, int[] a) 
    {
        Array.Sort(a);
        int mx = Math.Abs(a[0] - l);
        for (int i = 0; i < a.Length-1; i++)
        {
            int x = Math.Max(a[i], l), y = Math.Min(a[i+1], r);
            mx = Math.Max(mx, (y-x)-1);
        }
        mx = Math.Max(mx, Math.Abs(a[a.Length-1] - r));
        return mx;
    }
}