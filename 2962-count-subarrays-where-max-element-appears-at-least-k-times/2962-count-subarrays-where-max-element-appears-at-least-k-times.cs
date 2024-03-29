public class Solution {
    public long CountSubarrays(int[] a, int k) 
    {
        long mx = a.Max(), ans = 0, c = 0, n = a.Length;
        for (int i = 0, j = 0; i < n; i++)
        {
            if (a[i] == mx) c++;
            while(c >= k)
            {
                ans += n-i;
                if (a[j++] == mx) c--;
            }
        }
        return ans;
    }
}