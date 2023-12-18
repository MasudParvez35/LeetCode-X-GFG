public class Solution {
    public int MaxProductDifference(int[] a) 
    {
        int n = a.Length;
        int mx1 = 0, mx2 = 0, mi1 = int.MaxValue, mi2 = int.MaxValue;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] >= mx1)
            {
                mx2 = mx1;
                mx1 = a[i];
            }
            else if (a[i] > mx2) mx2 = a[i];
            if (mi1 >= a[i])
            {
                mi2 = mi1;
                mi1 = a[i];
            }
            else if (mi2 > a[i]) mi2 = a[i];
        }
        return mx1*mx2 - mi1*mi2;
    }
}
