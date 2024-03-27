public class Solution {
    public int NumSubarrayProductLessThanK(int[] a, int k) 
    {
        if (k <= 1) return 0;
        int f = 1;
        int ans = 0;
        for (int i = 0, j = 0; i < a.Length; i++)
        {
            f *= a[i];
            while(f >= k)
            {
                f /= a[j++];
            }
            ans += (i-j+1);
        }
        return ans;
    }
}