public class Solution {
    public long MinOperationsToMakeMedianK(int[] a, int k) 
    {
        Array.Sort(a);
        int n = a.Length;
        long ans = 0;
        for (int i = n/2; i >= 0; i--) {
            if (a[i] > k) ans += a[i]-k;
        }
        for (int i = n/2; i < n; i++) {
            if (a[i] < k) ans += k - a[i];
        }
        return ans;
    }
}
