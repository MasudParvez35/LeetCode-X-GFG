public class Solution {
    public int MinimumDeletions(string s, int k) 
    {
        int n = s.Length;
        int[] pre = new int[n];
        List <int> v = new List<int>();
        Dictionary<char,int> mp = new Dictionary<char,int>();
        foreach (char i in s) {
            if (!mp.ContainsKey(i)) mp[i] = 1;
            else mp[i]++;
        }
        foreach (var i in mp) {
            v.Add(i.Value);
        }
        v.Sort();
        for (int i = 0; i < v.Count(); i++) {
            if (i == 0) pre[i] = v[i];
            else pre[i] = v[i] + pre[i-1];
        }
        int ans = int.MaxValue;
        for (int i = 0; i < v.Count(); i++)
        {
            int sm = pre[i] - v[i];
            for (int j = i; j < v.Count(); j++)
            {
                if (v[j] > v[i]+k) sm += (v[j] - (v[i]+k));
            }
            ans = Math.Min(ans, sm);
        }
        return ans;
    }
}
