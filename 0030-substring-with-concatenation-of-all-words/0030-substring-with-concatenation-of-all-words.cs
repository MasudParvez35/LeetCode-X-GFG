public class Solution {
    public IList<int> FindSubstring(string s, string[] t) 
    {
        int n = t.Length, m = t[0].Length;
        IList<int> ans = new List<int>();
        int len = n*m;
        if (len > s.Length) return ans;
        Dictionary<string,int> mp = new Dictionary<string,int>();
        foreach (string i in t) {
            if (!mp.ContainsKey(i)) mp[i] = 0;
            mp[i]++;
        }
        for (int i = 0; i <= s.Length-len; i++)
        {
            Dictionary<string,int> pp = new Dictionary<string,int>(mp);
            int c = 0;
            for (int j = i; j < i+len; j += m) {
                string s1 = s.Substring(j,m);
                if (pp.ContainsKey(s1) && pp[s1] > 0) {
                    pp[s1]--;
                    c += m;
                }
                else break;
            }
            if (c == len) ans.Add(i);
        }
        return ans;
    }
}
