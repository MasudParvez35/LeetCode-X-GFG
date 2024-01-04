public class Solution {
    public int MinOperations(int[] a) 
    {
        Dictionary<int,int> mp = new Dictionary<int,int>();
        int ans = 0;
        for (int i = 0; i < a.Length; i++) {
            if (!mp.ContainsKey(a[i])) mp[a[i]] = 1;
            else mp[a[i]]++;
        }
        foreach(var i in mp)
        {
            if (i.Value == 1) return -1;
            ans += i.Value/3;
            if (i.Value % 3 != 0) ans++;
        }
        return ans;
    }
}