public class Solution {
    public long CountBadPairs(int[] a) 
    {
        int n = a.Length;
        long ans = (n*(long)(n-1))/2;
        Dictionary<int,int> mp = new Dictionary<int,int>();

        for (int i = 0; i < a.Length; i++) 
        {
            int x = i-a[i];
            if (!mp.ContainsKey(x)) 
                mp[x] = 1;
            else
                mp[x]++;
        }
        
        foreach(var i in mp)
        {
            long x = (i.Value*(long)(i.Value-1))/2;
            ans -= x;
        }

        return ans;
    }
}