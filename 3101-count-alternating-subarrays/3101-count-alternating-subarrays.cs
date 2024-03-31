public class Solution {
    public long CountAlternatingSubarrays(int[] a) 
    {
        long ans = 0, c = 0, pre = -1;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != pre) {
                c++;
                pre = a[i];
            }
            else 
            {
                ans += (c*(c+1))/2;
                pre = a[i];
                if (i < a.Length-1 && a[i+1] != a[i]) c = 1;
                else {
                    c = 0; ans++;
                }
            }
        }
        ans += (c*(c+1))/2;
        return ans;
    }
}
