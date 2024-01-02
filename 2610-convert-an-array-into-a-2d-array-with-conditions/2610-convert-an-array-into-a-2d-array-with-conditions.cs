public class Solution {
    public IList<IList<int>> FindMatrix(int[] v) 
    {
        Dictionary<int,int> mp = new Dictionary<int,int>();
        int mx = 0;
        foreach (var i in v) {
            if (!mp.ContainsKey(i)) mp[i] = 1;
            else mp[i]++;
            mx = Math.Max(mx, mp[i]);
        }
        List<IList<int>> ans = new List<IList<int>>(mx);
        for (int i = 0; i < mx; i++) {
            ans.Add(new List<int>());
        }
        foreach(var it in mp)
        {
            int c = it.Value;
            for (int i = 0; i < c; i++) {
                ans[i].Add(it.Key);
            }
        }
        return ans;
    }
}