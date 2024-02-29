public class Solution {
    public long CountGood(int[] a, int k) 
    {
        Dictionary<int,int> mp = new Dictionary<int,int>()    ;
        long ans = 0, sm = 0, n = a.Length;
        for (int i = 0, j = 0; i < n; i++)
        {
            if (!mp.ContainsKey(a[i])) mp[a[i]] = 1;
            else mp[a[i]]++;
            sm += mp[a[i]]-1;
            while(i > j && sm >= k)
            {
                ans += n-i;
                mp[a[j]]--;
                sm -= mp[a[j]];
                j++;
            }
        }
        return ans;
    }
}
