public class Solution {
    public int MaxSubarrayLength(int[] a, int k) 
    {
        Dictionary <int,int> mp = new Dictionary<int,int>();
        int ans = 0;
        for (int i = 0, j = 0; i < a.Length; i++)
        {
            if (!mp.ContainsKey(a[i])) mp[a[i]] = 1;
            else mp[a[i]]++;
            while(mp[a[i]] > k) {
                mp[a[j++]]--;
            }
            ans = Math.Max(ans, i-j+1);
        }
        return ans;
    }
}