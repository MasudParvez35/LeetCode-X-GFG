public class Solution {
    public int[] ResultsArray(int[] a, int k) 
    {
        int n = a.Length, pre = -1;
        if (k <= 1) return a;
        int[] ans = new int[n-k+1];
        for (int i = 1, j = 0; i < n; i++)
        {
            if (a[i]-a[i-1] != 1) pre = i;
            if (i-j+1 == k)
            {
                if (j >= pre) ans[j] = a[i];
                else ans[j] = -1;
                j++;
            }
        }
        return ans;
    }
}