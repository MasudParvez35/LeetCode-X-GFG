public class Solution {
    public int CountConsistentStrings(string s, string[] w) 
    {
        Dictionary<char,int> mp = new Dictionary<char,int>();
        foreach (char c in s) {
            if (!mp.ContainsKey(c)) mp[c] = 1;
        }
        int ans = 0;
        foreach (string ss in w)
        {
            bool flag = true;
            for (int i = 0; i < ss.Length; i++)
            {
                if (!mp.ContainsKey(ss[i])) {
                    flag = false;
                    break;
                }
            }
            if (flag)
                ans++;
        }
        return ans;
    }
}