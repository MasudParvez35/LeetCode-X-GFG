public class Solution {
    public int NumSubarraysWithSum(int[] a, int k) 
    {
        Dictionary<int,int> mp = new Dictionary<int,int>();
        mp[0] = 1;
        int ans = 0, sm = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sm += a[i];
            int x = sm - k;
            if (mp.ContainsKey(x)) {
                ans += mp[x];
            }
            if (!mp.ContainsKey(sm)) mp[sm] = 1;
            else mp[sm]++;
        }
        return ans;
    }
}